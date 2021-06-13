﻿using App.Models;

namespace App
{
    partial class Calculator
    {
        private void EnableDisableControlls()
        {
            if (!labelEmeraldVigor.Enabled)
            {
                labelEmeraldVigor.Enabled = true;
            }
            labelSpellPower.Enabled = true;
            textBoxSpellPower.Enabled = true;
            labelHaste.Enabled = true;
            textBoxHasteRating.Enabled = true;
            labelArrow.Enabled = true;
            labelPercent.Enabled = true;

            if (checkBoxEmeraldVigor.Checked == true)
            {
                this.numericUpDownEmeraldVigor.Enabled = true;
            }
            if (checkBoxGlyphOfHealingWave.Checked)
            {
                textBoxGlyphOfHealingWave.Enabled = true;
                labelAvgGlyphOfHealingWave.Enabled = true;
            }
            if (checkBoxGlyphChainHeal.Checked)
            {
                this.labelTarget4.Enabled = true;
                this.labelArrowcCrit4.Enabled = true;
                this.labelArrowHit4.Enabled = true;
                this.labelDashCrit4.Enabled = true;
                this.labelDashHit4.Enabled = true;
                this.labelTarget4.Enabled = true;
                this.textBoxAvgHot4.Enabled = true;
                this.textBoxCrit4Avg.Enabled = true;
                this.textBoxCrit4From.Enabled = true;
                this.textBoxCrit4To.Enabled = true;
                this.textBoxHit4Avg.Enabled = true;
                this.textBoxHit4From.Enabled = true;
                this.textBoxHit4To.Enabled = true;
            }
            else
            {
                this.labelTarget4.Enabled = false;
                this.labelArrowcCrit4.Enabled = false;
                this.labelArrowHit4.Enabled = false;
                this.labelDashCrit4.Enabled = false;
                this.labelDashHit4.Enabled = false;
                this.labelTarget4.Enabled = false;
                this.textBoxAvgHot4.Enabled = false;
                this.textBoxCrit4Avg.Enabled = false;
                this.textBoxCrit4From.Enabled = false;
                this.textBoxCrit4To.Enabled = false;
                this.textBoxHit4Avg.Enabled = false;
                this.textBoxHit4From.Enabled = false;
                this.textBoxHit4To.Enabled = false;
            }
            if (!checkBox4PT10Bonus.Checked && selectedSpell?.Name == Constants.SpellChainHeal)
            {
                this.labelAvgHot1.Enabled = false;
                labelChainedHeal1.Enabled = false;
                textBoxAvgHot1.Enabled = false;
                textBoxAvgHot2.Enabled = false;
                textBoxAvgHot3.Enabled = false;
                textBoxAvgHot4.Enabled = false;
                textBoxAvgHot4.Enabled = false;
                labelAvgHotHps.Enabled = false;
                labelChainedHeal2.Enabled = false;
                textBoxAvgHotHps.Enabled = false;
            }
            else
            {
                this.labelAvgHot1.Enabled = true;
                labelChainedHeal1.Enabled = true;
                textBoxAvgHot1.Enabled = true;
                textBoxAvgHot2.Enabled = true;
                textBoxAvgHot3.Enabled = true;
                if (this.checkBoxGlyphChainHeal.Checked)
                {
                    textBoxAvgHot4.Enabled = true;
                }
                labelAvgHotHps.Enabled = true;
                labelChainedHeal2.Enabled = true;
                textBoxAvgHotHps.Enabled = true;
            }
        }

        private void HideShowControlls(Spell selectedSpell)
        {
            this.labelDashCrit1.Hide();
            this.labelDashHit1.Hide();
            this.textBoxAvgHot1.Hide();
            this.textBoxCrit1Avg.Hide();
            this.textBoxCrit1From.Hide();
            this.labelArrowcCrit1.Hide();
            this.textBoxCrit1To.Hide();
            labelAvgHot1.Hide();
            labelCritMax.Hide();

            this.labelArrowcCrit2.Hide();
            this.labelArrowHit2.Hide();
            this.labelDashCrit2.Hide();
            this.labelDashHit2.Hide();
            this.labelTarget2.Hide();
            this.textBoxAvgHot2.Hide();
            this.textBoxCrit2Avg.Hide();
            this.textBoxCrit2From.Hide();
            this.textBoxCrit2To.Hide();
            this.textBoxHit2Avg.Hide();
            this.textBoxHit2From.Hide();
            this.textBoxHit2To.Hide();

            this.labelArrowcCrit3.Hide();
            this.labelArrowHit3.Hide();
            this.labelDashCrit3.Hide();
            this.labelDashHit3.Hide();
            this.labelTarget3.Hide();
            this.textBoxAvgHot3.Hide();
            this.textBoxCrit3Avg.Hide();
            this.textBoxCrit3From.Hide();
            this.textBoxCrit3To.Hide();
            this.textBoxHit3Avg.Hide();
            this.textBoxHit3From.Hide();
            this.textBoxHit3To.Hide();

            this.labelArrowcCrit4.Hide();
            this.labelArrowHit4.Hide();
            this.labelDashCrit4.Hide();
            this.labelDashHit4.Hide();
            this.labelTarget4.Hide();
            this.textBoxAvgHot4.Hide();
            this.textBoxCrit4Avg.Hide();
            this.textBoxCrit4From.Hide();
            this.textBoxCrit4To.Hide();
            this.textBoxHit4Avg.Hide();
            this.textBoxHit4From.Hide();
            this.textBoxHit4To.Hide();

            this.labelTarget1.Hide();
            this.labelTarget2.Hide();
            this.labelTarget3.Hide();
            this.labelTarget4.Hide();

            this.labelArrowHit1.Hide();
            this.textBoxHit1To.Hide();
            this.textBoxHit1Avg.Hide();

            labelChainedHeal1.Hide();
            labelChainedHeal2.Hide();
            labelCastingTime.Hide();
            labelEarthlivingBlessingOf.Hide();

            textBoxCastingTime.Hide();
            this.labelHit.Hide();
            this.labelTick.Hide();
            labelHitAvg.Hide();
            labelCritAvg.Hide();
            labelAvgHotHps.Hide();
            textBoxAvgHotHps.Hide();
            labelApproximately1.Hide();
            labelApproximately2.Hide();
            this.textBoxHit1From.Hide();
            textBoxAvgHps.Hide();
            labelForOneTarget.Hide();
            labelAncestralAwakening.Hide();
            textBoxAncestralAwaceningFrom.Hide();
            textBoxAncestralAwaceningTo.Hide();
            textBoxAncestralAwaceningAvg.Hide();
            labelAvgHps.Hide();
            labelAvgAA.Hide();
            labelAvgAAeHps.Hide();
            textBoxAvgAAeHps.Hide();
            labelSpamOnDifferent1.Hide();
            labelSpamOnDifferent2.Hide();
            labelSpamOn1Target1.Hide();
            labelSpamOn1Target2.Hide();
            labelHot.Hide();
            textBoxHotRiptide.Hide();
            textBoxGlyphOfHealingWave.Hide();
            labelAvgGlyphOfHealingWave.Hide();
            labelPerTick.Hide();
            textBoxEarthlivingAvgHpsCH.Hide();
            textBoxEarthlivingAvgHpsHW.Hide();
            textBoxEarthlivingAvgHpsLHW.Hide();
            textBoxEarthlivingAvgHpsRP.Hide();
            textBoxEarthlivingAvgHpsTotal.Hide();
            labeAvgHps2.Hide();
            labeEarthlivingHps3.Hide();
            labeEarthlivingHps4.Hide();
            labeEarthlivingHps5.Hide();
            labelEarthlivingCH.Hide();
            labelEarthlivingHW.Hide();
            labelEarthlivingLHW.Hide();
            labelEarthlivingRP.Hide();
            labelAvgAAHps2.Hide();
            labelEarthlivingHps1.Hide();
            labelEarthlivingHps2.Hide();
            labelChainHealStacking.Hide();
            labelAvgHpm.Hide();
            textBoxAvgHpm.Hide();
            labelAvgHpmAdditional1.Hide();
            labelAvgHpmAdditional2.Hide();
            labelFor1Target.Hide();

            textBoxMp5CHPM.Hide();
            textBoxMp5Crit.Hide();
            textBoxMp5LHWPM.Hide();
            textBoxMp5Percent.Hide();
            textBoxMp5RPM.Hide();
            textBoxMp5TotalCrit.Hide();
            textBoxMP5TimeDec.Hide();
            textBoxMP5TimeMin.Hide();
            textBoxMP5TimeSec.Hide();
            textBoxMP5TotalCH.Hide();
            textBoxMP5TotalHW.Hide();
            textBoxMP5TotalLHW.Hide();
            textBoxMP5TotalRiptides.Hide();
            textBoxMp5HWPM.Hide();
            labelMp5Arrow.Hide();
            labelMp5arrrow2.Hide();
            labelMp5Arrow3.Hide();
            labelMp5Arrow4.Hide();
            labelMp5Arrow5.Hide();
            labelMp5CHPM.Hide();
            labelMp5Crit.Hide();
            labelMp5LHealingWave.Hide();
            labelMP5LHWPM.Hide();
            labelMP5HWPM.Hide();
            labelMp5Min.Hide();
            labelMp5Mp5S.Hide();
            labelMp5Percent.Hide();
            labelMp5rightPercent.Hide();
            labelMp5RightTotalCrit.Hide();
            labelMp5RPM.Hide();
            labelMp5Sec.Hide();
            labelMp5TimeLength.Hide();
            labelMp5TotalCH.Hide();
            labelMp5TotalCritLeft.Hide();
            labelMp5TotalHealingWaves.Hide();
            labelMp5TotalRiptides.Hide();
            labelAdditionalCritical.Hide();
            labelAreNotIncluded.Hide();

            switch (selectedSpell.Name)
            {
                case Constants.SpellChainHeal:
                    labelAvgHpm.Show();
                    textBoxAvgHpm.Show();
                    labelAvgHpmAdditional1.Show();
                    labelAvgHpmAdditional2.Show();
                    labelChainHealStacking.Show();
                    labelHitAvg.Show();
                    labelHit.Show();
                    labelCritAvg.Show();
                    this.textBoxHit1From.Show();

                    this.labelArrowcCrit2.Show();
                    this.labelArrowHit2.Show();
                    this.labelDashCrit2.Show();
                    this.labelDashHit2.Show();
                    this.labelTarget2.Show();
                    this.textBoxAvgHot2.Show();
                    this.textBoxCrit2Avg.Show();
                    this.textBoxCrit2From.Show();
                    this.textBoxCrit2To.Show();
                    this.textBoxHit2Avg.Show();
                    this.textBoxHit2From.Show();
                    this.textBoxHit2To.Show();

                    this.labelArrowcCrit3.Show();
                    this.labelArrowHit3.Show();
                    this.labelDashCrit3.Show();
                    this.labelDashHit3.Show();
                    this.labelTarget3.Show();
                    this.textBoxAvgHot3.Show();
                    this.textBoxCrit3Avg.Show();
                    this.textBoxCrit3From.Show();
                    this.textBoxCrit3To.Show();
                    this.textBoxHit3Avg.Show();
                    this.textBoxHit3From.Show();
                    this.textBoxHit3To.Show();

                    this.labelArrowcCrit4.Show();
                    this.labelArrowHit4.Show();
                    this.labelDashCrit4.Show();
                    this.labelDashHit4.Show();
                    this.labelTarget4.Show();
                    this.textBoxAvgHot4.Show();
                    this.textBoxCrit4Avg.Show();
                    this.textBoxCrit4From.Show();
                    this.textBoxCrit4To.Show();
                    this.textBoxHit4Avg.Show();
                    this.textBoxHit4From.Show();
                    this.textBoxHit4To.Show();

                    this.labelTarget1.Show();
                    this.labelTarget2.Show();
                    this.labelTarget3.Show();
                    this.labelTarget4.Show();

                    this.labelArrowcCrit1.Show();
                    this.labelArrowHit1.Show();
                    this.labelDashCrit1.Show();
                    this.labelDashHit1.Show();
                    this.textBoxAvgHot1.Show();
                    this.textBoxCrit1Avg.Show();
                    this.textBoxCrit1From.Show();
                    this.textBoxCrit1To.Show();
                    this.textBoxHit1Avg.Show();
                    this.textBoxHit1To.Show();
                    labelAvgHot1.Show();
                    labelCritMax.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    labelChainedHeal1.Show();
                    checkBoxGlyphChainHeal.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    labelAvgHotHps.Show();
                    labelChainedHeal2.Show();
                    textBoxAvgHotHps.Show();
                    break;
                case Constants.SpellEarthliving:
                    textBoxAvgHps.Show();
                    textBoxHit1From.Show();
                    labelTick.Show();
                    labelEarthlivingBlessingOf.Show();
                    checkBoxGlyphOfEarthliving.Show();
                    textBoxAvgHotHps.Show();
                    textBoxEarthlivingAvgHpsCH.Show();
                    textBoxEarthlivingAvgHpsHW.Show();
                    textBoxEarthlivingAvgHpsLHW.Show();
                    textBoxEarthlivingAvgHpsRP.Show();
                    labelEarthlivingHps1.Show();
                    labelEarthlivingHps2.Show();
                    labeEarthlivingHps3.Show();
                    labeEarthlivingHps4.Show();
                    labelEarthlivingCH.Show();
                    labelEarthlivingHW.Show();
                    labelEarthlivingLHW.Show();
                    labelEarthlivingRP.Show();
                    break;
                case Constants.SpellHST:
                    labelFor1Target.Show();
                    labelAvgHpmAdditional1.Show();
                    labelAvgHpmAdditional2.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpm.Show();
                    textBoxHit1From.Show();
                    labelTick.Show();
                    textBoxAvgHotHps.Show();
                    labelForOneTarget.Show();
                    labelPerTick.Show();
                    labeAvgHps2.Show();
                    break;
                case Constants.SpellHW:
                    labelAvgHpmAdditional1.Show();
                    labelAvgHpmAdditional2.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpm.Show();
                    labelDashHit1.Show();
                    textBoxHit1To.Show();
                    labelArrowHit1.Show();
                    textBoxHit1Avg.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    labelDashCrit1.Show();
                    textBoxCrit1To.Show();
                    labelArrowcCrit1.Show();
                    textBoxCrit1Avg.Show();
                    labelCritAvg.Show();
                    textBoxCrit3From.Show();
                    labelDashCrit3.Show();
                    textBoxCrit3To.Show();
                    labelArrowcCrit3.Show();
                    textBoxCrit3Avg.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    labelHitAvg.Show();
                    labelAvgHps.Show();
                    labelAvgAAHps2.Show();
                    labelAvgAA.Show();
                    textBoxAvgHps.Show();
                    textBoxAvgHotHps.Show();
                    labelAncestralAwakening.Show();
                    textBoxAncestralAwaceningFrom.Show();
                    textBoxAncestralAwaceningTo.Show();
                    textBoxAncestralAwaceningAvg.Show();
                    textBoxHit1From.Show();
                    labelHit.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    textBoxGlyphOfHealingWave.Show();
                    labelAvgGlyphOfHealingWave.Show();
                    checkBoxGlyphOfHealingWave.Show();
                    break;
                case Constants.SpellLHW:
                    labelAvgHpmAdditional1.Show();
                    labelAvgHpmAdditional2.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpm.Show();
                    labelDashHit1.Show();
                    textBoxHit1To.Show();
                    labelArrowHit1.Show();
                    textBoxHit1Avg.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    labelDashCrit1.Show();
                    textBoxCrit1To.Show();
                    labelArrowcCrit1.Show();
                    textBoxCrit1Avg.Show();
                    labelCritAvg.Show();
                    textBoxCrit3From.Show();
                    labelDashCrit3.Show();
                    textBoxCrit3To.Show();
                    labelArrowcCrit3.Show();
                    textBoxCrit3Avg.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    labelHitAvg.Show();

                    labelAvgHps.Show();
                    labelAvgAAHps2.Show();
                    textBoxAvgHps.Show();

                    textBoxAvgHotHps.Show();
                    labelAvgAA.Show();

                    labelAncestralAwakening.Show();
                    textBoxAncestralAwaceningFrom.Show();
                    textBoxAncestralAwaceningTo.Show();
                    textBoxAncestralAwaceningAvg.Show();
                    textBoxHit1From.Show();
                    this.labelHit.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    break;
                case Constants.SpellESh:
                    labelAvgHpmAdditional1.Show();
                    labelAvgHpmAdditional2.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpm.Show();
                    labelApproximately1.Show();
                    labelApproximately2.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    this.labelHit.Show();
                    textBoxHit1From.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    break;
                case Constants.SpellRiptide:
                    labelAvgHpmAdditional1.Show();
                    labelAvgHpmAdditional2.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpm.Show();
                    labelHitAvg.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    labelAvgAA.Show();
                    labelAvgAAeHps.Show();
                    textBoxAvgAAeHps.Show();

                    labelDashHit1.Show();
                    textBoxHit1To.Show();
                    labelArrowHit1.Show();
                    textBoxHit1Avg.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    labelDashCrit1.Show();
                    textBoxCrit1To.Show();
                    labelArrowcCrit1.Show();
                    textBoxCrit1Avg.Show();
                    labelCritAvg.Show();
                    textBoxCrit3From.Show();
                    labelDashCrit3.Show();
                    textBoxCrit3To.Show();
                    labelArrowcCrit3.Show();
                    textBoxCrit3Avg.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    labelHitAvg.Show();
                    labelAncestralAwakening.Show();
                    textBoxAncestralAwaceningFrom.Show();
                    textBoxAncestralAwaceningTo.Show();
                    textBoxAncestralAwaceningAvg.Show();
                    textBoxHit1From.Show();
                    this.labelHit.Show();

                    labelSpamOnDifferent1.Show();
                    labelSpamOnDifferent2.Show();
                    labelSpamOn1Target1.Show();
                    labelSpamOn1Target2.Show();
                    labeAvgHps2.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    textBoxAvgHotHps.Show();
                    checkBoxGlyphOfRiptide.Show();
                    labelHot.Show();
                    textBoxHotRiptide.Show();
                    break;
                case Constants.SpellCritIntoMP5S:
                    textBoxMp5CHPM.Show();
                    textBoxMp5Crit.Show();
                    textBoxMp5LHWPM.Show();
                    textBoxMp5Percent.Show();
                    textBoxMp5RPM.Show();
                    textBoxMp5TotalCrit.Show();
                    textBoxMP5TimeDec.Show();
                    textBoxMP5TimeMin.Show();
                    textBoxMP5TimeSec.Show();
                    textBoxMP5TotalCH.Show();
                    textBoxMP5TotalHW.Show();
                    textBoxMP5TotalLHW.Show();
                    textBoxMP5TotalRiptides.Show();
                    textBoxMp5HWPM.Show();
                    labelMp5Arrow.Show();
                    labelMp5arrrow2.Show();
                    labelMp5Arrow3.Show();
                    labelMp5Arrow4.Show();
                    labelMp5Arrow5.Show();
                    labelMp5CHPM.Show();
                    labelMp5Crit.Show();
                    labelMp5LHealingWave.Show();
                    labelMP5LHWPM.Show();
                    labelMP5HWPM.Show();
                    labelMp5Min.Show();
                    labelMp5Mp5S.Show();
                    labelMp5Percent.Show();
                    labelMp5rightPercent.Show();
                    labelMp5RightTotalCrit.Show();
                    labelMp5RPM.Show();
                    labelMp5Sec.Show();
                    labelMp5TimeLength.Show();
                    labelMp5TotalCH.Show();
                    labelMp5TotalCritLeft.Show();
                    labelMp5TotalHealingWaves.Show();
                    labelMp5TotalRiptides.Show();
                    labelAdditionalCritical.Show();
                    labelAreNotIncluded.Show();
                    break;
            }
        }

        private void DisplayHealing()
        {
            this.textBoxHasteRating.Text = Player.Instance.HasteRating == 0 ? "" : Player.Instance.HasteRating.ToString();
            this.textBoxSpellPower.Text = Player.Instance.SpellPower == 0 ? "" : Player.Instance.SpellPower.ToString();
            this.textBoxHastePercent.Text = Player.Instance.HastePercent.ToString();
            this.textBoxHit1From.Text = Player.Instance.Hit1From.ToString();
            this.textBoxHit2From.Text = Player.Instance.Hit2From.ToString();
            this.textBoxHit3From.Text = Player.Instance.Hit3From.ToString();
            this.textBoxHit4From.Text = Player.Instance.Hit4From.ToString();
            this.textBoxHit1To.Text = Player.Instance.Hit1To.ToString();
            this.textBoxHit2To.Text = Player.Instance.Hit2To.ToString();
            this.textBoxHit3To.Text = Player.Instance.Hit3To.ToString();
            this.textBoxHit4To.Text = Player.Instance.Hit4To.ToString();
            this.textBoxHit1Avg.Text = Player.Instance.Hit1Avg.ToString();
            this.textBoxHit2Avg.Text = Player.Instance.Hit2Avg.ToString();
            this.textBoxHit3Avg.Text = Player.Instance.Hit3Avg.ToString();
            this.textBoxHit4Avg.Text = Player.Instance.Hit4Avg.ToString();
            this.textBoxCrit1From.Text = Player.Instance.Crit1From.ToString();
            this.textBoxCrit2From.Text = Player.Instance.Crit2From.ToString();
            this.textBoxCrit3From.Text = Player.Instance.Crit3From.ToString();
            this.textBoxCrit4From.Text = Player.Instance.Crit4From.ToString();
            this.textBoxCrit1To.Text = Player.Instance.Crit1To.ToString();
            this.textBoxCrit2To.Text = Player.Instance.Crit2To.ToString();
            this.textBoxCrit3To.Text = Player.Instance.Crit3To.ToString();
            this.textBoxCrit4To.Text = Player.Instance.Crit4To.ToString();
            this.textBoxCrit1Avg.Text = Player.Instance.Crit1Avg.ToString();
            this.textBoxCrit2Avg.Text = Player.Instance.Crit2Avg.ToString();
            this.textBoxCrit3Avg.Text = Player.Instance.Crit3Avg.ToString();
            this.textBoxCrit4Avg.Text = Player.Instance.Crit4Avg.ToString();
            this.textBoxAvgHot1.Text = Player.Instance.AvgHot1.ToString();
            this.textBoxAvgHot2.Text = Player.Instance.AvgHot2.ToString();
            this.textBoxAvgHot3.Text = Player.Instance.AvgHot3.ToString();
            this.textBoxAvgHot4.Text = Player.Instance.AvgHot4.ToString();
            this.textBoxHotRiptide.Text = Player.Instance.HotRiptide.ToString();
            this.textBoxAncestralAwaceningFrom.Text = Player.Instance.AncestralAwaceningFrom.ToString();
            this.textBoxAncestralAwaceningTo.Text = Player.Instance.AncestralAwaceningTo.ToString();
            this.textBoxAncestralAwaceningAvg.Text = Player.Instance.AncestralAwaceningAvg.ToString();
            this.textBoxAvgHps.Text = Player.Instance.AvgHps.ToString();
            this.textBoxAvgHotHps.Text = Player.Instance.AvgHotHps.ToString();
            textBoxAvgAAeHps.Text = Player.Instance.AvgAAHps.ToString();
            textBoxGlyphOfHealingWave.Text = Player.Instance.AvgGlyphOfHealingWave.ToString();
            textBoxAvgHpm.Text = Player.Instance.AvgHpm.ToString();
            //Earthliving
            textBoxEarthlivingAvgHpsCH.Text = Player.Instance.EarthlivingAvgHpsCH.ToString();
            textBoxEarthlivingAvgHpsHW.Text = Player.Instance.EarthlivingAvgHpsHW.ToString();
            textBoxEarthlivingAvgHpsLHW.Text = Player.Instance.EarthlivingAvgHpsLHW.ToString();
            textBoxEarthlivingAvgHpsRP.Text = Player.Instance.EarthlivingAvgHpsRP.ToString();
            textBoxEarthlivingAvgHpsTotal.Text = Player.Instance.EarthlivingAvgHpsTotal.ToString();
            //Mp5
            textBoxMP5TimeDec.Text = Player.Instance.Mp5TimeDec.ToString();
            textBoxMp5RPM.Text = Player.Instance.Mp5RPM.ToString();
            textBoxMp5HWPM.Text = Player.Instance.Mp5HWPM.ToString();
            textBoxMp5LHWPM.Text = Player.Instance.Mp5LHWPM.ToString();
            textBoxMp5CHPM.Text = Player.Instance.Mp5CHPM.ToString();
            textBoxMp5Crit.Text = Player.Instance.Mp5Crit.ToString();
            textBoxMp5Percent.Text = Player.Instance.Mp5Percent.ToString();
            textBoxMp5TotalCrit.Text = Player.Instance.Mp5TotalCrit.ToString();

            textBoxCastingTime.Text = Player.Instance.CastingTime.ToString();

            textBoxCriticalPercent.Text = Player.Instance.CriticalPercent.ToString();

            if (selectedSpell != null &&
                (selectedSpell.Name == Constants.SpellEarthliving || selectedSpell.Name == Constants.SpellHST))
            {
                labelAvgHps.Text = Constants.LabelAvgHps;
            }
            else if (selectedSpell != null &&
                (selectedSpell.Name == Constants.SpellHW || selectedSpell.Name == Constants.SpellLHW))
            {
                labelAvgHotHps.Text = Constants.LabelAvgHpsHealingWave;
                labelAvgHps.Text = Constants.LabelAvgHps;
            }
            else if (selectedSpell != null && selectedSpell.Name == Constants.SpellRiptide)
            {
                labelAvgHotHps.Text = Constants.LabelAvgHps;
            }
            else
            {
                labelAvgHotHps.Text = "AVG HOT eHPS:";
                labelAvgHps.Text = Constants.LabelAvgHps;

            }
        }
    }
}
