using App.Models;
using App.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    partial class Calculator
    {
        private void AddTooltips()
        {
            var toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.ReshowDelay = 50;
            toolTip.AutoPopDelay = 15000;
            toolTip.SetToolTip(pictureBoxHome, "Home");
            toolTip.SetToolTip(pictureBoxInfo, "Info");
            toolTip.SetToolTip(pictureBoxReset, "Reset");
            toolTip.SetToolTip(pictureBoxSound, "Sound");

            myToolTip.SetToolTip(checkBox2PT8Bonus, "mod");
            checkBox2PT8Bonus.Tag = Resources._2pT8_Bonus;

            myToolTip.SetToolTip(checkBox2PT9Bonus, "mod");
            checkBox2PT9Bonus.Tag = Resources._2pT9_Bonus;

            myToolTip.SetToolTip(checkBox4PT8Bonus, "mod");
            checkBox4PT8Bonus.Tag = Resources._4pT8_Bonus;

            myToolTip.SetToolTip(checkBox4PT9Bonus, "mod");
            checkBox4PT9Bonus.Tag = Resources._4pT9_Bonus;

            myToolTip.SetToolTip(checkBoxSteamcallersTotem, "mod");
            checkBoxSteamcallersTotem.Tag = Resources.ST;

            myToolTip.SetToolTip(checkBoxTreeOfLife, "Tree of life");
            checkBoxTreeOfLife.Tag = Resources.IDA___TOL;

            myToolTip.SetToolTip(checkBoxHellscream, "checkBoxHellscream");
            checkBoxHellscream.Tag = Resources.ICC_BUFF;

            myToolTip.SetToolTip(labelEmeraldVigor, "labelEmeraldVigor");
            labelEmeraldVigor.Tag = Resources.VDW_BUFF;

            myToolTip.SetToolTip(checkBoxEmeraldVigor, "some name");
            checkBoxEmeraldVigor.Tag = Resources.VDW_BUFF;

            myToolTip.SetToolTip(checkBoxRiptidesConsumption, "some name");
            checkBoxRiptidesConsumption.Tag = Resources.Riptide_s_consumption;

            myToolTip.SetToolTip(checkBoxGlyphOfEarthShield, "some name");
            checkBoxGlyphOfEarthShield.Tag = Resources.Glyph_of_Earth_Shield;

            myToolTip.SetToolTip(checkBoxGyphOfHST, "some name");
            checkBoxGyphOfHST.Tag = Resources.Glyph_of_Healing_Stream_Totem;

            myToolTip.SetToolTip(checkBoxGlyphOfLHW, "some name");
            checkBoxGlyphOfLHW.Tag = Resources.Glyph_of_Lesser_Healing_Wave;

            myToolTip.SetToolTip(checkBoxWrathOfTheAirTotem, "some name");
            checkBoxWrathOfTheAirTotem.Tag = Resources.Wrath_of_Air_Totem;

            myToolTip.SetToolTip(checkBoxSwiftRetributionHaste, "some name");
            checkBoxSwiftRetributionHaste.Tag = Resources.HASTE_BUFF;

            myToolTip.SetToolTip(checkBoxBloodlust, "some name");
            checkBoxBloodlust.Tag = Resources.Shaman_Blood___Hero;

            myToolTip.SetToolTip(checkBox2PT10Bonus, "some name");
            checkBox2PT10Bonus.Tag = Resources._2P_T10;

            myToolTip.SetToolTip(checkBoxTidalWaves, "some name");
            checkBoxTidalWaves.Tag = Resources.Tidal_Waves__Haste_;

            myToolTip.SetToolTip(checkBoxMoonkinForm, "some name");
            checkBoxMoonkinForm.Tag = Resources.Moonkin_Aura;

            myToolTip.SetToolTip(checkBoxTidalWavesCrit, "some name");
            checkBoxTidalWavesCrit.Tag = Resources.Tidal_Waves__Critical_;

            myToolTip.SetToolTip(checkBoxGlyphChainHeal, "some name");
            checkBoxGlyphChainHeal.Tag = Resources.Glyph_of_Chain_Heal;

            myToolTip.SetToolTip(checkBoxGlyphOfEarthliving, "some name");
            checkBoxGlyphOfEarthliving.Tag = Resources.Glyph_of_Earthliving_Weapon;

            myToolTip.SetToolTip(checkBoxGlyphOfRiptide, "some name");
            checkBoxGlyphOfRiptide.Tag = Resources.Glyph_of_Riptide;

            myToolTip.SetToolTip(checkBoxMetaRevitalizingSkyflareDiamond, "some name");
            checkBoxMetaRevitalizingSkyflareDiamond.Tag = Resources.Revitalizing_Skyflare_Diamond;

            myToolTip.SetToolTip(labelChainedHeal1, "some name");
            labelChainedHeal1.Tag = Resources.Chained_Heal;

            myToolTip.SetToolTip(labelChainedHeal2, "some name");
            labelChainedHeal2.Tag = Resources.Chained_Heal;

            myToolTip.SetToolTip(checkBoxGlyphOfHealingWave, "some name");
            checkBoxGlyphOfHealingWave.Tag = Resources.Glyph_of_Healing_Wave;

            myToolTip.SetToolTip(checkBox4PT7Bonus, "mod");
            checkBox4PT7Bonus.Tag = Resources._4P_T7;

            myToolTip.SetToolTip(checkBox2PT7Bonus, "mod");
            checkBox2PT7Bonus.Tag = Resources._2P_T7;

            myToolTip.SetToolTip(checkBox4PT10Bonus, "mod");
            checkBox4PT10Bonus.Tag = Resources._4P_T10;

            myToolTip.SetToolTip(checkBoxBerserking, "mod");
            checkBoxBerserking.Tag = Resources.Berserking__Troll_;

            myToolTip.SetToolTip(checkBoxGlyphOfManaTideTotem, "mod");
            checkBoxGlyphOfManaTideTotem.Tag = Resources.Glyph_of_MTT;

            myToolTip.SetToolTip(checkBoxMetaInsightfulEarthsiegeDiamond, "mod");
            checkBoxMetaInsightfulEarthsiegeDiamond.Tag = Resources.IED;

            myToolTip.SetToolTip(checkBoxTotemOfForestGrowth, "mod");
            checkBoxTotemOfForestGrowth.Tag = Resources.Totem_of_Forest_Growth;

            myToolTip.SetToolTip(checkBoxTotemOfMisery, "mod");
            checkBoxTotemOfMisery.Tag = Resources.Totem_of_Misery;

            myToolTip.SetToolTip(checkBoxTotemOfTheBay, "mod");
            checkBoxTotemOfTheBay.Tag = Resources.Totem_of_the_Bay;

            myToolTip.SetToolTip(labelMp5Totems, "mod");
            labelMp5Totems.Tag = Resources.MTT;

            myToolTip.SetToolTip(labelMp5Innervates, "mod");
            labelMp5Innervates.Tag = Resources.Innervate;

            myToolTip.SetToolTip(labelMp5Replenish, "mod");
            labelMp5Replenish.Tag = Resources.Replenishment;

            myToolTip.SetToolTip(labelMp5InsightfulEarthsiegeDiamond, "mod");
            labelMp5InsightfulEarthsiegeDiamond.Tag = Resources.IED;

            myToolTip.SetToolTip(labelGlyphOfHealingWave, "mod");
            labelGlyphOfHealingWave.Tag = Resources.Glyph_of_Healing_Wave;

            myToolTip.SetToolTip(labelMp5TotemicRecall, "mod");
            labelMp5TotemicRecall.Tag = Resources.Totemic_Recall;

            myToolTip.SetToolTip(labelMp5RevitalizeRank, "mod");
            labelMp5RevitalizeRank.Tag = Resources.Revitalize;

            myToolTip.SetToolTip(labelMp5RaptureRank, "mod");
            labelMp5RaptureRank.Tag = Resources.Rapture;

            myToolTip.SetToolTip(labelMp5RunicManaPotion, "mod");
            labelMp5RunicManaPotion.Tag = Resources.RunicManaPotion;

            myToolTip.SetToolTip(checkBoxMp5RunicManaInjector, "mod");
            checkBoxMp5RunicManaInjector.Tag = Resources.RunicManaInjector;

            myToolTip.SetToolTip(labelMp5BloodlustHeroism, "mod");
            labelMp5BloodlustHeroism.Tag = Resources.Bloodlust;

            myToolTip.SetToolTip(labelMp5CallOfElements, "mod");
            labelMp5CallOfElements.Tag = Resources.CallOfElements;

            myToolTip.SetToolTip(labelMP5CleanseSpirit, "mod");
            labelMP5CleanseSpirit.Tag = Resources.CleanseSpirit;

            myToolTip.SetToolTip(checkBoxFocusMagic, "mod");
            checkBoxFocusMagic.Tag = Resources.Focus_Magic;
        }

        private void SelectSpellImage(Spell selectedSpell)
        {
            switch (selectedSpell.Name)
            {
                case Constants.SpellChainHeal:
                    pictureBoxSpell.Image = Resources.SpellCHain_Heal;
                    break;

                case Constants.SpellEarthliving:
                    pictureBoxSpell.Image = Resources.SpellEarthliving;
                    break;

                case Constants.SpellESh:
                    pictureBoxSpell.Image = Resources.SpellEarth_Shield;
                    break;

                case Constants.SpellHST:
                    pictureBoxSpell.Image = Resources.SpellHealing_Stream_Totem;
                    break;

                case Constants.SpellHW:
                    pictureBoxSpell.Image = Resources.SpellHealing_Wave;
                    break;

                case Constants.SpellLHW:
                    pictureBoxSpell.Image = Resources.SpellLesser_Healing_Wave;
                    break;

                case Constants.SpellRiptide:
                    pictureBoxSpell.Image = Resources.SpellRiptide;
                    break;

                case Constants.SpellCritIntoMP5S:
                    pictureBoxSpell.Image = Resources.WSh;
                    break;

                case Constants.SpellGiftOfTheNaaru:
                    pictureBoxSpell.Image = Resources.GotNPicture;
                    break;

                default:
                    break;
            }
        }

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
                labelMp5Mana4.Enabled = true;
            }
            else
            {
                labelMp5InsightfulEarthsiegeDiamond.Enabled = false;
                textBoxMp5Diamond.Enabled = false;
                labelMp5Mana4.Enabled = false;
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
            labeAvgHps2.Hide();
            labeEarthlivingHps3.Hide();
            labelAvgAAHps2.Hide();
            labelEarthlivingHps1.Hide();
            labelAvgHealingEarthliving.Hide();
            labelAvgHpm.Hide();
            textBoxAvgHpmManyTargets.Hide();
            labelFor1Target.Hide();

            textBoxMp5CHPM.Hide();
            textBoxMp5Crit.Hide();
            textBoxMp5LHWPM.Hide();
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
            labelMp5Mana1.Hide();
            labelMp5Mana2.Hide();
            labelMp5Mana3.Hide();
            labelMp5Mana4.Hide();
            labelGlyphOfHealingWave.Hide();
            textBoxMp5TotalCHCasts.Hide();
            labelMp5TotalCHCasts.Hide();
            labelMp5BloodlustHeroism.Hide();
            numericUpDownMp5BloodlustHeroism.Hide();
            labelMp5TotalManaSpent.Hide();
            textBoxMp5TotalManaSpent.Hide();
            labelMp5TotalESHCasts.Hide();
            textBoxMp5TotalESHCasts.Hide();
            comboBoxAirTotems.Hide();
            comboBoxEarthTotems.Hide();
            comboBoxFireTotems.Hide();
            comboBoxWaterTotems.Hide();
            numericUpDownMp5CallOfElements.Hide();
            numericUpDownMp5TotemicRecall.Hide();
            labelMp5TotemicRecall.Hide();
            labelMp5CallOfElements.Hide();
            labelMp5Casts1.Hide();
            labelMp5Casts2.Hide();
            labelmp5Casts3.Hide();
            labelmp5Casts4.Hide();
            labelMp5Casts5.Hide();
            comboBoxAirTotems.Hide();
            comboBoxWaterTotems.Hide();
            comboBoxFireTotems.Hide();
            comboBoxEarthTotems.Hide();
            labelMp5RevitalizeMana.Hide();
            labelMp5RevitalizeRank.Hide();
            numericUpDownMp5Revitalize.Hide();
            textBoxMp5Revitalize.Hide();
            labelMp5PerTickOf.Hide();
            labelMp5TicksRevitalize.Hide();
            labelMp5RaptureMana.Hide();
            labelMp5RaptureProcs.Hide();
            labelMp5RaptureRank.Hide();
            labelMp5RapturePerProc.Hide();
            numericUpDownMp5Rapture.Hide();
            textBoxMp5Rapture.Hide();
            labelMp5ManaDifference.Hide();
            textBoxMp5ManaDifference.Hide();
            labelMp5CastsCleanseSpirit.Hide();
            labelMP5CleanseSpirit.Hide();
            numericUpDownMp5CleanseSpirit.Hide();
            checkBoxMp5RunicManaInjector.Hide();
            labelMp5RunicManaPotion.Hide();
            labelMp5RunicPotionUses.Hide();
            numericUpDownMp5RunicManaPotion.Hide();
            labelMP5ManaSpenders.Hide();
            labelMp5ManaGainEffects.Hide();
            labelEarthlivingPerCastCH.Hide();
            labelEarthlivingPerCastR.Hide();
            labelEarthlivingCastHW.Hide();
            labelEarthlivingCastLHW.Hide();
            labelEarthlivingHPSr.Hide();
            labelEarthlivingHPSCH.Hide();
            labelEarthlivingHPSHW.Hide();
            labelEarthlivingHPSLHW.Hide();
            labelEarthlivingEHPS.Hide();
            textBoxEarthlivingEHPS.Hide();
            pictureBoxAirTotem.Hide();
            pictureBoxEarthTotem.Hide();
            pictureBoxFireTotem.Hide();
            pictureBoxWaterTotem.Hide();

            switch (selectedSpell.Name)
            {
                case Constants.SpellChainHeal:
                    labelEarthlivingPerCastCH.Show();
                    labelEarthlivingHPSCH.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
                    labelHitAvg.Show();
                    labelHit.Show();
                    labelCritAvg.Show();
                    textBoxHit1From.Show();
                    labelArrowcCrit2.Show();
                    labelArrowHit2.Show();
                    labelDashCrit2.Show();
                    labelDashHit2.Show();
                    labelTarget2.Show();
                    textBoxAvgHot2.Show();
                    textBoxCrit2Avg.Show();
                    textBoxCrit2From.Show();
                    textBoxCrit2To.Show();
                    textBoxHit2Avg.Show();
                    textBoxHit2From.Show();
                    textBoxHit2To.Show();
                    labelArrowcCrit3.Show();
                    labelArrowHit3.Show();
                    labelDashCrit3.Show();
                    labelDashHit3.Show();
                    labelTarget3.Show();
                    textBoxAvgHot3.Show();
                    textBoxCrit3Avg.Show();
                    textBoxCrit3From.Show();
                    textBoxCrit3To.Show();
                    textBoxHit3Avg.Show();
                    textBoxHit3From.Show();
                    textBoxHit3To.Show();
                    labelArrowcCrit4.Show();
                    labelArrowHit4.Show();
                    labelDashCrit4.Show();
                    labelDashHit4.Show();
                    labelTarget4.Show();
                    textBoxAvgHot4.Show();
                    textBoxCrit4Avg.Show();
                    textBoxCrit4From.Show();
                    textBoxCrit4To.Show();
                    textBoxHit4Avg.Show();
                    textBoxHit4From.Show();
                    textBoxHit4To.Show();
                    labelTarget1.Show();
                    labelTarget2.Show();
                    labelTarget3.Show();
                    labelTarget4.Show();
                    labelArrowcCrit1.Show();
                    labelArrowHit1.Show();
                    labelDashCrit1.Show();
                    labelDashHit1.Show();
                    textBoxAvgHot1.Show();
                    textBoxCrit1Avg.Show();
                    textBoxCrit1From.Show();
                    textBoxCrit1To.Show();
                    textBoxHit1Avg.Show();
                    textBoxHit1To.Show();
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
                    labelEarthlivingEHPS.Show();
                    textBoxEarthlivingEHPS.Show();
                    break;

                case Constants.SpellEarthliving:
                    textBoxAvgHps.Show();
                    textBoxHit1From.Show();
                    labelTick.Show();
                    checkBoxGlyphOfEarthliving.Show();
                    textBoxAvgHotHps.Show();
                    labelEarthlivingHps1.Show();
                    labelAvgHealingEarthliving.Show();
                    labeEarthlivingHps3.Show();
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
                    labelEarthlivingCastHW.Show();
                    labelEarthlivingHPSHW.Show();
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
                    labelGlyphOfHealingWave.Show();
                    labelEarthlivingEHPS.Show();
                    textBoxEarthlivingEHPS.Show();
                    break;

                case Constants.SpellLHW:
                    labelEarthlivingCastLHW.Show();
                    labelEarthlivingHPSLHW.Show();
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
                    labelEarthlivingEHPS.Show();
                    textBoxEarthlivingEHPS.Show();
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
                    labelEarthlivingPerCastR.Show();
                    labelEarthlivingHPSr.Show();
                    labelAvgHpm.Show();
                    textBoxAvgHpmManyTargets.Show();
                    labelHitAvg.Show();
                    checkBoxMetaRevitalizingSkyflareDiamond.Show();
                    labelAvgAA.Show();
                    labelAvgAAeHps.Show();
                    textBoxAvgAAeHps.Show();
                    textBoxEarthlivingEHPS.Show();
                    labelEarthlivingEHPS.Show();
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
                    labelMp5Mana1.Show();
                    labelMp5Mana2.Show();
                    labelMp5Mana3.Show();
                    labelMp5Mana4.Show();
                    textBoxMp5TotalCHCasts.Show();
                    labelMp5TotalCHCasts.Show();
                    labelMp5BloodlustHeroism.Show();
                    numericUpDownMp5BloodlustHeroism.Show();
                    labelMp5TotalManaSpent.Show();
                    textBoxMp5TotalManaSpent.Show();
                    labelMp5TotalESHCasts.Show();
                    textBoxMp5TotalESHCasts.Show();
                    comboBoxAirTotems.Show();
                    comboBoxEarthTotems.Show();
                    comboBoxFireTotems.Show();
                    comboBoxWaterTotems.Show();
                    numericUpDownMp5CallOfElements.Show();
                    numericUpDownMp5TotemicRecall.Show();
                    labelMp5TotemicRecall.Show();
                    labelMp5CallOfElements.Show();
                    labelMp5Casts1.Show();
                    labelMp5Casts2.Show();
                    labelmp5Casts3.Show();
                    labelmp5Casts4.Show();
                    labelMp5Casts5.Show();
                    comboBoxAirTotems.Show();
                    comboBoxWaterTotems.Show();
                    comboBoxFireTotems.Show();
                    comboBoxEarthTotems.Show();
                    labelMp5RevitalizeMana.Show();
                    labelMp5RevitalizeRank.Show();
                    numericUpDownMp5Revitalize.Show();
                    textBoxMp5Revitalize.Show();
                    labelMp5PerTickOf.Show();
                    labelMp5TicksRevitalize.Show();
                    labelMp5RaptureMana.Show();
                    labelMp5RaptureProcs.Show();
                    labelMp5RaptureRank.Show();
                    labelMp5RapturePerProc.Show();
                    numericUpDownMp5Rapture.Show();
                    textBoxMp5Rapture.Show();
                    labelMp5ManaDifference.Show();
                    textBoxMp5ManaDifference.Show();
                    labelMp5CastsCleanseSpirit.Show();
                    labelMP5CleanseSpirit.Show();
                    numericUpDownMp5CleanseSpirit.Show();
                    checkBoxMp5RunicManaInjector.Show();
                    labelMp5RunicManaPotion.Show();
                    labelMp5RunicPotionUses.Show();
                    numericUpDownMp5RunicManaPotion.Show();
                    labelMP5ManaSpenders.Show();
                    labelMp5ManaGainEffects.Show();
                    pictureBoxAirTotem.Show();
                    pictureBoxEarthTotem.Show();
                    pictureBoxFireTotem.Show();
                    pictureBoxWaterTotem.Show();
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
            //Mp5
            textBoxMP5TimeDec.Text = Player.Instance.Mp5TimeDec.ToString();
            textBoxMp5RPM.Text = Player.Instance.Mp5RPM.ToString();
            textBoxMp5HWPM.Text = Player.Instance.Mp5HWPM.ToString();
            textBoxMp5LHWPM.Text = Player.Instance.Mp5LHWPM.ToString();
            textBoxMp5CHPM.Text = Player.Instance.Mp5CHPM.ToString();
            textBoxMp5Crit.Text = Player.Instance.Mp5Crit.ToString();
            textBoxMp5TotalCrit.Text = Player.Instance.Mp5TotalCrit.ToString();
            textBoxMp5Totems.Text = Player.Instance.Mp5Totems.ToString();
            textBoxMp5Innervates.Text = Player.Instance.Mp5Innervates.ToString();
            textBoxMp5Replenish.Text = Player.Instance.Mp5Replenish.ToString();
            textBoxMp5Diamond.Text = Player.Instance.Mp5Diamond.ToString();
            textBoxMp5Revitalize.Text = Player.Instance.Mp5RevitalizeMana.ToString();
            textBoxMp5TotalManaGain.Text = Player.Instance.Mp5TotalManaGain.ToString();
            textBoxMp5TotalManaSpent.Text = Player.Instance.Mp5TotalManaSpent.ToString();
            textBoxMp5Rapture.Text = Player.Instance.Mp5RaptureMana.ToString();
            textBoxMp5ManaDifference.Text = Player.Instance.Mp5ManaDifference.ToString();
            textBoxEarthlivingEHPS.Text = Player.Instance.EarthlivingEHPS.ToString();

            if (Player.Instance.Mp5ManaDifference > Player.Instance.Mana)
            {
                textBoxMp5ManaDifference.BackColor = textBoxMp5ManaDifference.BackColor;
                textBoxMp5ManaDifference.ForeColor = Color.Green;
                //textBoxMp5ManaDifference.ReadOnly = false;
            }
            else if (Player.Instance.Mp5ManaDifference < 0)
            {
                textBoxMp5ManaDifference.BackColor = textBoxMp5ManaDifference.BackColor;
                textBoxMp5ManaDifference.ForeColor = Color.Red;
                //textBoxMp5ManaDifference.ReadOnly = false;
            }
            else
            {
                //textBoxMp5ManaDifference.ReadOnly = true;
                textBoxMp5ManaDifference.ForeColor = Color.Black;
            }

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
                    labelAvgHotHps.Text = Constants.LabelChainHealAvgHotEhps;
                    textBoxAvgHealingEarthliving.Text = Player.Instance.EarthlivingAvgHpsCH.ToString();
                    break;

                default:
                    labelAvgHotHps.Text = Constants.LabelChainHealAvgHotEhps;
                    labelAvgHps.Text = Constants.LabelAvgHps;
                    break;
            }
        }
    }
}