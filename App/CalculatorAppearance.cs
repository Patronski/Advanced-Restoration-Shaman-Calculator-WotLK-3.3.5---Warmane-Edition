using App.Models;

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
                numericUpDownEmeraldVigor.Enabled = true;
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
                labelTarget4.Enabled = false;
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

            if (checkBoxMetaInsightfulEarthsiegeDiamond.Checked)
            {
                labelMp5InsightfulEarthsiegeDiamond.Enabled = true;
                textBoxMp5Diamond.Enabled = true;
            }
            else
            {
                labelMp5InsightfulEarthsiegeDiamond.Enabled = false;
                textBoxMp5Diamond.Enabled = false;
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

            textBoxCastingTime.Hide();
            this.labelHit.Hide();
            this.labelTick.Hide();
            labelHitAvg.Hide();
            labelCritAvg.Hide();
            labelAvgHotHps.Hide();
            textBoxAvgHotHps.Hide();
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
            labelSpamOn1Target1.Hide();
            labelHot.Hide();
            textBoxHotRiptide.Hide();
            textBoxGlyphOfHealingWave.Hide();
            labelAvgGlyphOfHealingWave.Hide();
            textBoxEarthlivingAvgHpsCH.Hide();
            textBoxEarthlivingAvgHpsHW.Hide();
            textBoxEarthlivingAvgHpsLHW.Hide();
            textBoxEarthlivingAvgHpsRP.Hide();
            labeAvgHps2.Hide();
            labeEarthlivingHps3.Hide();
            labeEarthlivingHps4.Hide();
            labeEarthlivingHps5.Hide();
            labelAvgAAHps2.Hide();
            labelEarthlivingHps1.Hide();
            labelAvgHealingEarthliving.Hide();
            labelAvgHpm.Hide();
            textBoxAvgHpmManyTargets.Hide();
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
            labelMp5Totems.Hide();
            labelMp5Innervates.Hide();
            labelMp5Replenish.Hide();
            labelMp5ReplenishPercent.Hide();
            labelMp5InsightfulEarthsiegeDiamond.Hide();
            numericUpDownMp5Totems.Hide();
            numericUpDownMp5Inervates.Hide();
            numericUpDownMp5Replenish.Hide();
            textBoxMp5Totems.Hide();
            textBoxMp5Innervates.Hide();
            textBoxMp5Replenish.Hide();
            textBoxMp5Diamond.Hide();
            labelMp5TotalManaGain.Hide();
            textBoxMp5TotalManaGain.Hide();
            labelTickEarthliving.Hide();
            textBoxTickEarthliving.Hide();
            labelAvgHealingEarthliving.Hide();
            textBoxAvgHealingEarthliving.Hide();
            pictureBoxSpellEarthliving.Hide();
            labelEarthliving.Hide();
            labelEarthlivingRank6.Hide();
            labelAvgHpm2.Hide();
            textBoxAvgHpmOneTarget.Hide();
            labelSpamOnDifferent3.Hide();
            labelSpamOn1Target3.Hide();

            switch (selectedSpell.Name)
            {
                case Constants.SpellChainHeal:
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
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
                    labelTickEarthliving.Show();
                    textBoxTickEarthliving.Show();
                    labelAvgHealingEarthliving.Show();
                    textBoxAvgHealingEarthliving.Show();
                    pictureBoxSpellEarthliving.Show();
                    labelEarthliving.Show();
                    labelEarthlivingRank6.Show();
                    break;

                case Constants.SpellEarthliving:
                    textBoxAvgHps.Show();
                    textBoxHit1From.Show();
                    labelTick.Show();
                    checkBoxGlyphOfEarthliving.Show();
                    textBoxAvgHotHps.Show();
                    textBoxEarthlivingAvgHpsCH.Show();
                    textBoxEarthlivingAvgHpsHW.Show();
                    textBoxEarthlivingAvgHpsLHW.Show();
                    textBoxEarthlivingAvgHpsRP.Show();
                    labelEarthlivingHps1.Show();
                    labelAvgHealingEarthliving.Show();
                    labeEarthlivingHps3.Show();
                    labeEarthlivingHps4.Show();
                    break;

                case Constants.SpellHST:
                    labelFor1Target.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
                    textBoxHit1From.Show();
                    labelTick.Show();
                    textBoxAvgHotHps.Show();
                    labelForOneTarget.Show();
                    labeAvgHps2.Show();
                    break;

                case Constants.SpellHW:
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
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
                    labelTickEarthliving.Show();
                    textBoxTickEarthliving.Show();
                    labelAvgHealingEarthliving.Show();
                    textBoxAvgHealingEarthliving.Show();
                    pictureBoxSpellEarthliving.Show();
                    labelEarthliving.Show();
                    labelEarthlivingRank6.Show();
                    break;

                case Constants.SpellLHW:
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
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
                    labelHit.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    labelTickEarthliving.Show();
                    textBoxTickEarthliving.Show();
                    labelAvgHealingEarthliving.Show();
                    textBoxAvgHealingEarthliving.Show();
                    pictureBoxSpellEarthliving.Show();
                    labelEarthliving.Show();
                    labelEarthlivingRank6.Show();
                    break;

                case Constants.SpellESh:
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    labelHit.Show();
                    textBoxHit1From.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    break;

                case Constants.SpellRiptide:
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
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
                    labelHit.Show();

                    labelSpamOnDifferent1.Show();
                    labelSpamOn1Target1.Show();
                    labeAvgHps2.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    textBoxAvgHotHps.Show();
                    checkBoxGlyphOfRiptide.Show();
                    labelHot.Show();
                    textBoxHotRiptide.Show();
                    labelTickEarthliving.Show();
                    textBoxTickEarthliving.Show();
                    labelAvgHealingEarthliving.Show();
                    textBoxAvgHealingEarthliving.Show();
                    pictureBoxSpellEarthliving.Show();
                    labelEarthliving.Show();
                    labelEarthlivingRank6.Show();
                    labelAvgHpm2.Show();
                    textBoxAvgHpmOneTarget.Show();
                    labelSpamOnDifferent3.Show();
                    labelSpamOn1Target3.Show();
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
                    labelMp5Totems.Show();
                    labelMp5Innervates.Show();
                    labelMp5Replenish.Show();
                    labelMp5ReplenishPercent.Show();
                    labelMp5InsightfulEarthsiegeDiamond.Show();
                    numericUpDownMp5Totems.Show();
                    numericUpDownMp5Inervates.Show();
                    numericUpDownMp5Replenish.Show();
                    textBoxMp5Totems.Show();
                    textBoxMp5Innervates.Show();
                    textBoxMp5Replenish.Show();
                    textBoxMp5Diamond.Show();
                    labelMp5TotalManaGain.Show();
                    textBoxMp5TotalManaGain.Show();
                    break;

                case Constants.SpellGiftOfTheNaaru:
                    labelTick.Show();
                    labelAvgHps.Show();
                    textBoxHit1From.Show(); // Tick
                    textBoxAvgHps.Show();
                    break;
            }
        }

        private void DisplayHealing()
        {
            textBoxHasteRating.Text = Player.Instance.HasteRating == 0 ? "" : Player.Instance.HasteRating.ToString();
            textBoxSpellPower.Text = Player.Instance.SpellPower == 0 ? "" : Player.Instance.SpellPower.ToString();
            textBoxHastePercent.Text = Player.Instance.HastePercent.ToString();
            textBoxCriticalPercent.Text = Player.Instance.CriticalPercent.ToString();
            textBoxIntellect.Text = Player.Instance.Intellect == 0 ? "" : Player.Instance.Intellect.ToString();
            textBoxMana.Text = Player.Instance.Mana.ToString();

            textBoxHit1From.Text = Player.Instance.Hit1From.ToString();
            textBoxHit2From.Text = Player.Instance.Hit2From.ToString();
            textBoxHit3From.Text = Player.Instance.Hit3From.ToString();
            textBoxHit4From.Text = Player.Instance.Hit4From.ToString();
            textBoxHit1To.Text = Player.Instance.Hit1To.ToString();
            textBoxHit2To.Text = Player.Instance.Hit2To.ToString();
            textBoxHit3To.Text = Player.Instance.Hit3To.ToString();
            textBoxHit4To.Text = Player.Instance.Hit4To.ToString();
            textBoxHit1Avg.Text = Player.Instance.Hit1Avg.ToString();
            textBoxHit2Avg.Text = Player.Instance.Hit2Avg.ToString();
            textBoxHit3Avg.Text = Player.Instance.Hit3Avg.ToString();
            textBoxHit4Avg.Text = Player.Instance.Hit4Avg.ToString();
            textBoxCrit1From.Text = Player.Instance.Crit1From.ToString();
            textBoxCrit2From.Text = Player.Instance.Crit2From.ToString();
            textBoxCrit3From.Text = Player.Instance.Crit3From.ToString();
            textBoxCrit4From.Text = Player.Instance.Crit4From.ToString();
            textBoxCrit1To.Text = Player.Instance.Crit1To.ToString();
            textBoxCrit2To.Text = Player.Instance.Crit2To.ToString();
            textBoxCrit3To.Text = Player.Instance.Crit3To.ToString();
            textBoxCrit4To.Text = Player.Instance.Crit4To.ToString();
            textBoxCrit1Avg.Text = Player.Instance.Crit1Avg.ToString();
            textBoxCrit2Avg.Text = Player.Instance.Crit2Avg.ToString();
            textBoxCrit3Avg.Text = Player.Instance.Crit3Avg.ToString();
            textBoxCrit4Avg.Text = Player.Instance.Crit4Avg.ToString();
            textBoxAvgHot1.Text = Player.Instance.AvgHot1.ToString();
            textBoxAvgHot2.Text = Player.Instance.AvgHot2.ToString();
            textBoxAvgHot3.Text = Player.Instance.AvgHot3.ToString();
            textBoxAvgHot4.Text = Player.Instance.AvgHot4.ToString();
            textBoxHotRiptide.Text = Player.Instance.HotRiptide.ToString();
            textBoxAncestralAwaceningFrom.Text = Player.Instance.AncestralAwaceningFrom.ToString();
            textBoxAncestralAwaceningTo.Text = Player.Instance.AncestralAwaceningTo.ToString();
            textBoxAncestralAwaceningAvg.Text = Player.Instance.AncestralAwaceningAvg.ToString();
            textBoxAvgHps.Text = Player.Instance.AvgHps.ToString();
            textBoxAvgHotHps.Text = Player.Instance.AvgHotHps.ToString();
            textBoxAvgAAeHps.Text = Player.Instance.AvgAAHps.ToString();
            textBoxGlyphOfHealingWave.Text = Player.Instance.AvgGlyphOfHealingWave.ToString();
            textBoxAvgHpmManyTargets.Text = Player.Instance.AvgHpm.ToString();
            textBoxAvgHpmOneTarget.Text = Player.Instance.AvgHpmOneTarget.ToString();
            //Earthliving
            textBoxEarthlivingAvgHpsCH.Text = Player.Instance.EarthlivingAvgHpsCH.ToString();
            textBoxEarthlivingAvgHpsHW.Text = Player.Instance.EarthlivingAvgHpsHW.ToString();
            textBoxEarthlivingAvgHpsLHW.Text = Player.Instance.EarthlivingAvgHpsLHW.ToString();
            textBoxEarthlivingAvgHpsRP.Text = Player.Instance.EarthlivingAvgHpsRP.ToString();
            //Mp5
            textBoxMP5TimeDec.Text = Player.Instance.Mp5TimeDec.ToString();
            textBoxMp5RPM.Text = Player.Instance.Mp5RPM.ToString();
            textBoxMp5HWPM.Text = Player.Instance.Mp5HWPM.ToString();
            textBoxMp5LHWPM.Text = Player.Instance.Mp5LHWPM.ToString();
            textBoxMp5CHPM.Text = Player.Instance.Mp5CHPM.ToString();
            textBoxMp5Crit.Text = Player.Instance.Mp5Crit.ToString();
            textBoxMp5Percent.Text = Player.Instance.Mp5Percent.ToString();
            textBoxMp5TotalCrit.Text = Player.Instance.Mp5TotalCrit.ToString();
            textBoxMp5Totems.Text = Player.Instance.Mp5Totems.ToString();
            textBoxMp5Innervates.Text = Player.Instance.Mp5Innervates.ToString();
            textBoxMp5Replenish.Text = Player.Instance.Mp5Replenish.ToString();
            textBoxMp5Diamond.Text = Player.Instance.Mp5Diamond.ToString();
            textBoxMp5TotalManaGain.Text = Player.Instance.Mp5TotalManaGain.ToString();

            textBoxCastingTime.Text = Player.Instance.CastingTime.ToString();
            textBoxTickEarthliving.Text = Player.Instance.EarthlivingTick.ToString();

            switch (selectedSpell?.Name)
            {
                case Constants.SpellHST:
                    labelAvgHps.Text = Constants.LabelAvgHps;
                    break;

                case Constants.SpellLHW:
                    labelAvgHotHps.Text = Constants.LabelAvgHpsHealingWave;
                    labelAvgHps.Text = Constants.LabelAvgHps;
                    textBoxAvgHealingEarthliving.Text = Player.Instance.EarthlivingAvgHpsLHW.ToString();
                    break;

                case Constants.SpellHW:
                    labelAvgHotHps.Text = Constants.LabelAvgHpsHealingWave;
                    labelAvgHps.Text = Constants.LabelAvgHps;
                    textBoxAvgHealingEarthliving.Text = Player.Instance.EarthlivingAvgHpsHW.ToString();
                    break;

                case Constants.SpellRiptide:
                    labelAvgHotHps.Text = Constants.LabelAvgHps;
                    textBoxAvgHealingEarthliving.Text = Player.Instance.EarthlivingAvgHpsRP.ToString();
                    break;

                case Constants.SpellChainHeal:
                    textBoxAvgHealingEarthliving.Text = Player.Instance.EarthlivingAvgHpsCH.ToString();
                    break;

                default:
                    labelAvgHotHps.Text = "AVG HOT eHPS:";
                    labelAvgHps.Text = Constants.LabelAvgHps;
                    break;
            }
        }
    }
}