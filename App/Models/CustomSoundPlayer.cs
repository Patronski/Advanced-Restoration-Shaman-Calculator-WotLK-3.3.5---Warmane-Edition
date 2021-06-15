using App.Properties;
using System.Media;

namespace App.Models
{
    public class CustomSoundPlayer : SoundPlayer
    {
        private bool isOffSoundPlayed;
        private bool isOnSoundPlayed;

        public void StopSound()
        {
            this.Stop();
        }

        internal void PlaySound(string name)
        {
            if (!Player.Instance.MuteSound)
            {
                switch (name)
                {
                    case "on":
                        if (!isOnSoundPlayed)
                        {
                            this.Stream = Resources.ON_S;
                            this.Play();
                            isOnSoundPlayed = true;
                        }
                        return;
                    case "off":
                        if (!isOffSoundPlayed)
                        {
                            this.Stream = Resources.OFF_S;
                            this.PlaySync();
                            isOffSoundPlayed = true;
                        }
                        return;
                    case Constants.SpellChainHeal:
                        this.Stream = Resources.CH;
                        break;
                    case Constants.SpellEarthliving:
                        this.Stream = Resources.EarthL;
                        break;
                    case Constants.SpellESh:
                        this.Stream = Resources.ES;
                        break;
                    case Constants.SpellHST:
                        this.Stream = Resources.HST;
                        break;
                    case Constants.SpellHW:
                        this.Stream = Resources.HW;
                        break;
                    case Constants.SpellLHW:
                        this.Stream = Resources.LHW;
                        break;
                    case Constants.SpellRiptide:
                        this.Stream = Resources.RP;
                        break;
                    case Constants.SpellCritIntoMP5S:
                        this.Stream = Resources.WShSound;
                        break;
                    case Constants.SpellGiftOfTheNaaru:
                        Stream = Resources.GotN;
                        break;
                }
                this.Play();
            }
        }
    }
}
