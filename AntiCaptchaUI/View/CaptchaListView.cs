using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AntiCaptcha;
using Newtonsoft.Json;

namespace AntiCaptchaUI.View
{
    public partial class CaptchaListView : UserControl
    {
        private readonly HashSet<AntiCaptchaKey> _captchaKeys;
        public CaptchaListView()
        {
            InitializeComponent();
            _captchaKeys = new HashSet<AntiCaptchaKey>();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addKeyForm = new AddKey();
            if (addKeyForm.ShowDialog(this) == DialogResult.OK)
            {
                var antiCaptcha = new AntiCaptchaKey(addKeyForm.ClientKey);

                AddKeys(antiCaptcha);
            }

        }

        public void SaveKeys(string path = "CaptchaKeys.json")
        {
            ICollection<AntiCaptchaKey> keysToSave;
            lock (_captchaKeys)
            {
                keysToSave = _captchaKeys.ToList();
            }

            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(keysToSave, Formatting.Indented));
            }
        }
        public async void SaveKeysAsync(string path = "CaptchaKeys.json")
        {
            ICollection<AntiCaptchaKey> keysToSave;
            lock (_captchaKeys)
            {
                keysToSave = _captchaKeys.ToList();
            }

            using (var sw = new StreamWriter(path))
            {
                await sw.WriteLineAsync(JsonConvert.SerializeObject(keysToSave, Formatting.Indented));
            }
        }
        public void LoadKeys(string path = "CaptchaKeys.json")
        {
            ICollection<AntiCaptchaKey> keysToLoad;
  
            using (var sr = new StreamReader(path))
                keysToLoad = JsonConvert.DeserializeObject<ICollection<AntiCaptchaKey>>(sr.ReadToEnd());
            
            AddKeys(keysToLoad.ToArray());
        }
        public async void LoadKeysAsync(string path = "CaptchaKeys.json")
        {
            ICollection<AntiCaptchaKey> keysToLoad;

            using (var sr = new StreamReader(path))
                keysToLoad = JsonConvert.DeserializeObject<ICollection<AntiCaptchaKey>>(await sr.ReadToEndAsync());
  
            AddKeys(keysToLoad.ToArray());
        }
        private void AddKeys(params AntiCaptchaKey[] keys)
        {
            lock (_captchaKeys)
            {
                foreach (var key in keys)
                {
                    if (AntiCaptchaLoadBalancer.AddKey(key))
                        _captchaKeys.Add(key);
                }
            }

            fastObjectListViewCaptchaKeys.SetObjects(_captchaKeys);
        }
        private void RemoveKeys(params AntiCaptchaKey[] keys)
        {
            lock (_captchaKeys)
            {
                foreach (var key in keys)
                {
                    if (AntiCaptchaLoadBalancer.RemoveKey(key))
                        _captchaKeys.Remove(key);
                }
            }

            fastObjectListViewCaptchaKeys.SetObjects(_captchaKeys);
        }
        private void fastObjectListViewCaptchaKeys_DoubleClick(object sender, EventArgs e)
        {
            if (fastObjectListViewCaptchaKeys.SelectedObjects.Count == 0) return;

            var anticaptchakey = fastObjectListViewCaptchaKeys.SelectedObject as AntiCaptchaKey;
            if (anticaptchakey != null)
            {
                var showtaskForm = new TaskListViewForm(anticaptchakey.Tasks);
                showtaskForm.Show(this);
                //showtaskForm.Dispose();
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (_captchaKeys == null || _captchaKeys.Count == 0) return;

            lock (_captchaKeys)
                fastObjectListViewCaptchaKeys.RefreshObject(_captchaKeys.FirstOrDefault());

        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keys = fastObjectListViewCaptchaKeys.SelectedObjects.Cast<AntiCaptchaKey>().ToArray();
            RemoveKeys(keys);
        }
    }
}
