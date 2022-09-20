using Fiddler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShatterlineProxy.Responses.Inventory;
using ShatterlineProxy.Responses.Progression;
using static ShatterlineProxy.Responses.Inventory.InventoryItems;

namespace ShatterlineProxy {
    public partial class MainForm : Form {
        private readonly string[] ACCEPTED_HOSTNAMES = { "playtest-rel065live.playtest-rel065.aws.fraglab.com" };

        private bool maxWepProgression;
        private bool unlockAll;
        private bool unreleasedOutfit;
        private bool unreleasedLMG;
        private bool mobSpawnerGrenade;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            if (!FiddlerApplication.IsStarted()) {
                if (!CertMaker.rootCertExists()) {
                    CertMaker.createRootCert();
                    CertMaker.trustRootCert();
                    Log("Fiddler cert installed.");
                }

                FiddlerApplication.BeforeRequest += OnBeforeRequest;
                FiddlerApplication.BeforeResponse += OnBeforeResponse;
                FiddlerApplication.ResponseHeadersAvailable += OnResponseHeadersAvailable;
                FiddlerApplication.Startup(8888, true, true, true);

                Log("Fiddler started.");
            }
        }

        private void Stop() {
            if (FiddlerApplication.IsStarted()) {
                if (CertMaker.rootCertExists()) {
                    CertMaker.removeFiddlerGeneratedCerts();
                    Log("Fiddler cert uninstalled.");
                }

                FiddlerApplication.Shutdown();
                Log("Stopped fiddler.");
            }

            if (FiddlerApplication.oProxy != null) {
                if (FiddlerApplication.oProxy.IsAttached) {
                    FiddlerApplication.oProxy.Detach();
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Stop();
        }

        private void OnBeforeResponse(Session oSession) {
            if (!ACCEPTED_HOSTNAMES.Contains(oSession.hostname)) {
                return;
            }

            // Decompress the response.
            oSession.utilDecodeResponse();
            string body = oSession.GetResponseBodyAsString();

            if (oSession.uriContains("inventory/items")) {
                // Lazy workaround to avoid incorrectly handling a response with a similar name.
                if (oSession.uriContains("seen")) {
                    return;
                }

                List<InventoryItems> response = JsonConvert.DeserializeObject<List<InventoryItems>>(body);

                if (unlockAll) {
                    List<string> ownedWeapons = new List<string>();

                    // Figure out which weapons we already own.
                    foreach (InventoryItems item in response) {
                        if (Constants.WEAPON_NAMES.Contains(item.item_name)) {
                            ownedWeapons.Add(item.item_name);
                        }
                    }

                    // Add weapons we don't own.
                    foreach (string wpnName in Constants.WEAPON_NAMES) {
                        // Ignore owned weapons.
                        if (ownedWeapons.Contains(wpnName)) {
                            continue;
                        }

                        response.Add(new InventoryItems() {
                            item_name = wpnName,
                            slots = new List<Slot>(),
                            amount = 1,
                            capacity = 0,
                            seen = true
                        });
                    }
                }

                if (unreleasedLMG || unreleasedOutfit || mobSpawnerGrenade) {
                    foreach (InventoryItems item in response) {
                        if (Constants.CHARACTER_NAMES.Contains(item.item_name)) {
                            foreach (Slot slot in item.slots) {
                                if (unreleasedOutfit && slot.slot_name == "outfit") {
                                    slot.item_name = "i_chosen_outfit01";
                                }

                                if (unreleasedLMG && slot.slot_name == "primary_weapon") {
                                    slot.item_name = "lmg02_invasion_proto";
                                }

                                if (mobSpawnerGrenade && slot.slot_name == "grenade_2") {
                                    slot.item_name = "spg04_invasion_proto";
                                }
                            }
                        }
                    }
                }

                oSession.utilSetResponseBody(JsonConvert.SerializeObject(response));

            } else if (oSession.uriContains("progression/weapons") && maxWepProgression) {
                Weapons weapons = JsonConvert.DeserializeObject<Weapons>(body);
                weapons.tier = 5;
                weapons.mastery_score = 400000;
                
                foreach (Weapons.Weapon weapon in weapons.weapons) {
                    weapon.locked = false;
                    weapon.level = 13;
                    weapon.score = 20000;
                }

                oSession.utilSetResponseBody(JsonConvert.SerializeObject(weapons));

            }
        }
        
        private void OnBeforeRequest(Session oSession) {
            // Accept gzipped responses.
            oSession.oRequest["Accept-Encoding"] = "gzip";
        }

        private void OnResponseHeadersAvailable(Session oSession) {
            if (ACCEPTED_HOSTNAMES.Contains(oSession.hostname)) {
                // Allow response editing.
                oSession.bBufferResponse = true;
            }
        }

        private void Log(string message) {
            string newMessage = message + Environment.NewLine;

            // Avoid cross-thread issues.
            if (InvokeRequired) {
                Invoke(new Action<string>(Log), new object[] { newMessage });
                return;
            }

            TxtLog.AppendText(newMessage);
            TxtLog.ScrollToCaret();
        }

        private void BtnStop_Click(object sender, EventArgs e) {
            Stop();
        }

        // Done like this to avoid cross-thread issues
        private void CheckMaxWeaponProgression_CheckedChanged(object sender, EventArgs e) {
            maxWepProgression = !maxWepProgression;
        }

        private void CheckUnlockAll_CheckedChanged(object sender, EventArgs e) {
            unlockAll = !unlockAll;
        }

        private void CheckUnreleasedOutfit_CheckedChanged(object sender, EventArgs e) {
            unreleasedOutfit = !unreleasedOutfit;
        }

        private void CheckUnreleasedLMG_CheckedChanged(object sender, EventArgs e) {
            unreleasedLMG = !unreleasedLMG;
        }

        private void CheckMobGrenade_CheckedChanged(object sender, EventArgs e) {
            mobSpawnerGrenade = !mobSpawnerGrenade;
        }
    }
}
