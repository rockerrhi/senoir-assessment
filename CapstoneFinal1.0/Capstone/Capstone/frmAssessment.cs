using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capstone
{

    public partial class frmAssessment : Form
    {
        public frmAssessment()
        {
            InitializeComponent();
        }
            private void FrmAssessment_FormClosing(object sender, FormClosingEventArgs e)
{
    this.Close();
}
        //////////////////////////////////////////////Validators////////////////////////////////////////////////////
        private bool IsCastValid()
        {
            return Validator.IsPresent(patientIDTextBox8) &&
            Validator.IsPresent(dateTimeTextBox);
        }
        private bool IsIVValid()
        {
            return Validator.IsPresent(IVpatientIDTextBox) &&
                Validator.IsPresent(IVdateTimeTextBox);
        }

        private bool IsSkinValid()
        {
            return Validator.IsPresent(patientIDTextBoxSkin) &&
                Validator.IsPresent(dateTimeTextBoxSkin);
  
        }
        private bool IsGastroValid()
        {
            return Validator.IsPresent(patientIDTextBoxGastro) &&
                Validator.IsPresent(dateTimeTextBoxGastro);
        }
        private bool IsGenitoValid()
        {
            return Validator.IsPresent(patientIDTextBoxGenit) &&
                Validator.IsPresent(dateTimeTextBoxGenit);
        }
        private bool IsRespValid()
        {
            return Validator.IsPresent(patientIDTextBoxResp) &&
                Validator.IsPresent(dateTimeTextBoxResp);
        }
        private bool IsNeuroValid()
        {
            return Validator.IsPresent(patientIDTextBoxNeuro) &&
                Validator.IsPresent(dateTimeTextBoxNeuro);
            }
        ////////////////////////////////////////////// End Validators////////////////////////////////////////////////////
        private void frmAssessment_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Neurological' table. You can move, or remove it, as needed.
            //this.neurologicalTableAdapter.Fill(this.capstone_Project_FinalDataSet.Neurological);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Respiratory' table. You can move, or remove it, as needed.
            //this.respiratoryTableAdapter.Fill(this.capstone_Project_FinalDataSet.Respiratory);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Cardiovascular' table. You can move, or remove it, as needed.
            //this.cardiovascularTableAdapter.Fill(this.capstone_Project_FinalDataSet.Cardiovascular);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Genitourinary' table. You can move, or remove it, as needed.
            //this.genitourinaryTableAdapter.Fill(this.capstone_Project_FinalDataSet.Genitourinary);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Gastrointestinal' table. You can move, or remove it, as needed.
            //this.gastrointestinalTableAdapter.Fill(this.capstone_Project_FinalDataSet.Gastrointestinal);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.SkinIntegrity' table. You can move, or remove it, as needed.
            //this.skinIntegrityTableAdapter.Fill(this.capstone_Project_FinalDataSet.SkinIntegrity);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Pain' table. You can move, or remove it, as needed.
            //this.painTableAdapter.Fill(this.capstone_Project_FinalDataSet.Pain);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet.Intravenous' table. You can move, or remove it, as needed.
            //this.intravenousTableAdapter.Fill(this.capstone_Project_FinalDataSet.Intravenous);
            //// TODO: This line of code loads data into the 'capstone_Project_FinalDataSet._Cast_Extremity_Assessment' table. You can move, or remove it, as needed.
            //this.cast_Extremity_AssessmentTableAdapter.Fill(this.capstone_Project_FinalDataSet._Cast_Extremity_Assessment);
        }
        ////////////////////////////////////////Cast///////////////////////////////////////////////////////////////////
        private void cast_Extremity_AssessmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            MessageBox.Show("Patient ID = " + patientIDTextBox8, "Test");
            this.cast_Extremity_AssessmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);
        }
        private void btnCastNew_Click(object sender, EventArgs e)
        {
            this.cast_Extremity_AssessmentBindingSource.AddNew();
            //this.cast_Extremity_AssessmentBindingNavigator.Items["bindingNavigatorAddNewItem"].PerformClick();
            tsBtnSearchCast.Enabled = false;

            patientIDTextBox8.ReadOnly = false;
            dateTimeTextBox.ReadOnly = false;

            drainageComboBox.Enabled = true;
            ifDrainageYesTextBox.ReadOnly = false;
            extremityColorComboBox.Enabled = true;
            extremityTemperatureComboBox.Enabled = true;
            extremitySensationComboBox.Enabled = true;
            extremityPainIncreaseComboBox.Enabled = true;
            ifPainIncreaseYesTextBox.ReadOnly = false;
            extremitySwellingComboBox.Enabled = true;
            ifSwellingYesTextBox.ReadOnly = false;

            btnCastSave.Enabled = true;
            btnCastNew.Enabled = false;
        }
        private void btnCastSave_Click(object sender, EventArgs e)
        {
            if (IsCastValid())
            {
                this.Validate();
                this.cast_Extremity_AssessmentBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);
                this.cast_Extremity_AssessmentTableAdapter.Update(this.capstone_Project_FinalDataSet);

                btnCastNew.Enabled = true;
                tsBtnSearchCast.Enabled = true;

                patientIDTextBox8.Clear();
                dateTimeTextBox.Clear();

                drainageComboBox.SelectedIndex = -1;
                ifDrainageYesTextBox.Clear();
                extremityColorComboBox.SelectedIndex = -1;
                extremityTemperatureComboBox.SelectedIndex = -1;
                extremitySensationComboBox.SelectedIndex = -1;
                extremityPainIncreaseComboBox.SelectedIndex = -1;
                ifPainIncreaseYesTextBox.Clear();
                extremitySwellingComboBox.SelectedIndex = -1;
                ifSwellingYesTextBox.Clear();
                btnCastNew.Enabled = true;
            }
        }
        private void tsBtnSearchCast_Click(object sender, EventArgs e)
        {
            try
            {
                this.cast_Extremity_AssessmentTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet._Cast_Extremity_Assessment, tsTxtCastPtID.Text);
                btnCastSave.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void tsbBackCast_Click_1(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
            
        }
        //////////////////////////////////////////////End Cast//////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////IV//////////////////////////////////////////////////////////////////////
        private void btnIVNew_Click(object sender, EventArgs e)
        {
            this.intravenousBindingSource.AddNew();
            //this.bindingNavigatorIV.Items["bindingNavigatorAddNewItem"].PerformClick();

            IVpatientIDTextBox.ReadOnly = false;
            IVdateTimeTextBox.ReadOnly = false;
            typeLineComboBox.Enabled = true;
            ifTypeLinePeripheralTextBox.ReadOnly = false;
            insertionSiteComboBox.Enabled = true;
            iVFluidsComboBox.Enabled = true;
            iVFluidsDescriptionTextBox.ReadOnly = false;
            iVOverHrsTextBox.ReadOnly = false;
            pCAComboBox.Enabled = true;
            pCAFentanylComboBox.Enabled = true;
            ifPCAFentanylEpiduralComboBox.Enabled = true;
            ifPCAFentanylEpiduralOtherTextBox.ReadOnly = false;
            pCAContinuousDoseTextBox.ReadOnly = false;
            pCADemandDoseTextBox.ReadOnly = false;
            pCAMaxDosePerHourTextBox.ReadOnly = false;

            btnIVSave.Enabled = true;
            btnIVNew.Enabled = false;
        }
        private void btnIVSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsIVValid())
                {
                    this.Validate();
                    this.intravenousBindingSource.EndEdit();
                    //this.tableAdapterManager.UpdateAll(this.capstone_Project_FinalDataSet);
                    this.intravenousTableAdapter.Update(this.capstone_Project_FinalDataSet);

                    IVpatientIDTextBox.Clear();
                    IVdateTimeTextBox.Clear();
                    typeLineComboBox.SelectedIndex = -1;
                    ifTypeLinePeripheralTextBox.Clear();
                    insertionSiteComboBox.SelectedIndex = -1;
                    iVFluidsComboBox.SelectedIndex = -1;
                    iVFluidsDescriptionTextBox.Clear();
                    iVOverHrsTextBox.Clear();
                    pCAComboBox.SelectedIndex = -1;
                    pCAFentanylComboBox.SelectedIndex = -1;
                    ifPCAFentanylEpiduralComboBox.SelectedIndex = -1;
                    ifPCAFentanylEpiduralOtherTextBox.Clear();
                    pCAContinuousDoseTextBox.Clear();
                    pCADemandDoseTextBox.Clear();
                    pCAMaxDosePerHourTextBox.Clear();

                    tsBtnIVSearch.Enabled = true;
                    btnIVNew.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnBackIV_Click_1(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        private void tsBtnIVSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.intravenousTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet.Intravenous, tsTxtIVPtID.Text);
                btnIVSave.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        //////////////////////////////////////////////End IV//////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////Skin//////////////////////////////////////////////////////////////////////
        private void btnNewSkin_Click(object sender, EventArgs e)
        {
            this.skinIntegrityBindingSource.AddNew();

            patientIDTextBoxSkin.ReadOnly = false;
            dateTimeTextBoxSkin.ReadOnly = false;
            skinColorComboBox.Enabled = true;
            skinIsComboBox.Enabled = true;
            skinisDescriptionTextBox.ReadOnly = false;
            signsofInflammationComboBox.Enabled = true;
            signsofInflammationLocationTextBox.ReadOnly = false;
            contusionEcchymosisComboBox.Enabled = true;
            contusionEcchymosisLengthTextBox.ReadOnly = false;
            contusionEcchymosisLocationsTextBox.ReadOnly = false;

            btnSaveSkin.Enabled = true;
            btnNewSkin.Enabled = false;

        }
        private void btnSaveSkin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSkinValid())
                {
                    this.Validate();
                    this.skinIntegrityBindingSource.EndEdit();
                    this.skinIntegrityTableAdapter.Update(this.capstone_Project_FinalDataSet);

                    patientIDTextBoxSkin.Clear();
                    dateTimeTextBoxSkin.Clear();
                    skinColorComboBox.SelectedIndex = -1;
                    skinIsComboBox.SelectedIndex = -1;
                    skinisDescriptionTextBox.Clear();
                    signsofInflammationComboBox.SelectedIndex = -1;
                    signsofInflammationLocationTextBox.Clear();
                    contusionEcchymosisComboBox.SelectedIndex = -1;
                    contusionEcchymosisLengthTextBox.Clear();
                    contusionEcchymosisLocationsTextBox.Clear();

                    tsBtnBackSkin.Enabled = true;
                    btnNewSkin.Enabled = true;

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void tsBtnBackSkin_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        private void tsBtnSearchSkin_Click(object sender, EventArgs e)
        {
            try
            {
                this.skinIntegrityTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet.SkinIntegrity, tsTxtPtIDSkin.Text);
                btnSaveSkin.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        //////////////////////////////////////////////End Skin//////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////Gastro//////////////////////////////////////////////////////////////////////
        private void btnNewGastro_Click(object sender, EventArgs e)
        {
            this.gastrointestinalBindingSource.AddNew();

            patientIDTextBoxGastro.ReadOnly = false;
            dateTimeTextBoxGastro.ReadOnly = false;
            oralMucosaComboBox.Enabled = true;
            tongueComboBox.Enabled = true;
            abdomenComboBox.Enabled = true;
            abdominalGirthTextBox.ReadOnly = false;
            bowelMovementsComboBox.Enabled = true;
            bowelMovementsOtherTextBox.ReadOnly = false;
            lastBowelMovementComboBox.Enabled = true;
            lastBowelMovementOtherTextBox.ReadOnly = false;
            continentComboBox.Enabled = true;
            nutritionalIntakeComboBox.Enabled = true;
            bowelSoundsComboBox.Enabled = true;
            tubesComboBox.Enabled = true;
            insertionSiteComboBox1.Enabled = true;
            tubesPHAspirateTextBox.ReadOnly = false;
            tubeFeedingTypeTextBox.ReadOnly = false;
            tubeFeedingAmountTextBox.ReadOnly = false;
            tubeFeedingComboBox.Enabled = true;
            stomaComboBox.Enabled = true;
            stomaStatusComboBox.Enabled = true;

            btnSaveGastro.Enabled = true;
            btnNewGastro.Enabled = false;

        }
        private void btnSaveGastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsGastroValid())
                {
                    this.Validate();
                    this.gastrointestinalBindingSource.EndEdit();
                    this.gastrointestinalTableAdapter.Update(this.capstone_Project_FinalDataSet);

                    patientIDTextBoxGastro.Clear();
                    dateTimeTextBoxGastro.Clear();
                    oralMucosaComboBox.SelectedIndex = -1;
                    tongueComboBox.SelectedIndex = -1;
                    abdomenComboBox.SelectedIndex = -1;
                    abdominalGirthTextBox.Clear();
                    bowelMovementsComboBox.SelectedIndex = -1;
                    bowelMovementsOtherTextBox.Clear();
                    lastBowelMovementComboBox.SelectedIndex = -1;
                    lastBowelMovementOtherTextBox.Clear();
                    continentComboBox.SelectedIndex = -1;
                    nutritionalIntakeComboBox.SelectedIndex = -1;
                    bowelSoundsComboBox.SelectedIndex = -1;
                    tubesComboBox.SelectedIndex = -1;
                    insertionSiteComboBox1.SelectedIndex = -1;
                    tubesPHAspirateTextBox.Clear();
                    tubeFeedingTypeTextBox.Clear();
                    tubeFeedingAmountTextBox.Clear();
                    tubeFeedingComboBox.SelectedIndex = -1;
                    stomaComboBox.SelectedIndex = -1;
                    stomaStatusComboBox.SelectedIndex = -1;

                    tsBtnSearchGastro.Enabled = true;
                    btnNewGastro.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void tsBtnBackGastro_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        private void tsBtnSearchGastro_Click(object sender, EventArgs e)
        {
            try
            {
                this.gastrointestinalTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet.Gastrointestinal, tsTxtPtIDGastro.Text);
                btnSaveGastro.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        //////////////////////////////////////////////End Gastro//////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////Genito//////////////////////////////////////////////////////////////////////
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.genitourinaryTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet.Genitourinary, tsTxtPtIDGenit.Text);
                btnSaveGenit.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        private void btnSaveGenit_Click(object sender, EventArgs e)
        {
            if (IsGenitoValid())
            {
                this.Validate();
                this.genitourinaryBindingSource.EndEdit();
                this.genitourinaryTableAdapter.Update(this.capstone_Project_FinalDataSet);

                patientIDTextBoxGenit.Clear();
                dateTimeTextBoxGenit.Clear();
                genitaliaComboBox.SelectedIndex = -1;
                ifGenitaliaAbnormalitiesTextBox.Clear();
                urinationAssessmentComboBox.SelectedIndex = -1;
                continentComboBox.SelectedIndex = -1;
                continentGenComboBox.SelectedIndex = -1;
                urineAmountComboBox.SelectedIndex = -1;
                urineColorComboBox.SelectedIndex = -1;
                urineCharComboBox.SelectedIndex = -1;
                urostomyComboBox.SelectedIndex = -1;
                stomaStatusComboBox1.SelectedIndex = -1;
                urinaryStentsComboBox.SelectedIndex = -1;
                urinaryCatheterComboBox.SelectedIndex = -1;
                insertionSiteComboBox2.SelectedIndex = -1;

                tsBtnSearchGenit.Enabled = true;
                btnNewGenit.Enabled = true;
            }

        }
        private void btnNewGenit_Click(object sender, EventArgs e)
        {
            this.genitourinaryBindingSource.AddNew();

            patientIDTextBoxGenit.ReadOnly = false;
            dateTimeTextBoxGenit.ReadOnly = false;
            genitaliaComboBox.Enabled = true;
            ifGenitaliaAbnormalitiesTextBox.ReadOnly = false;
            urinationAssessmentComboBox.Enabled = true;
            continentComboBox.Enabled = true;
            continentGenComboBox.Enabled = true;
            urineAmountComboBox.Enabled = true;
            urineColorComboBox.Enabled = true;
            urineCharComboBox.Enabled = true;
            urostomyComboBox.Enabled = true;
            stomaStatusComboBox1.Enabled = true;
            urinaryStentsComboBox.Enabled = true;
            urinaryCatheterComboBox.Enabled = true;
            insertionSiteComboBox2.Enabled = true;

            btnSaveGenit.Enabled = true;
            btnNewGenit.Enabled = false;
            
        }
        //////////////////////////////////////////////End Genito//////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////Resp//////////////////////////////////////////////////////////////////////
        private void btnNewResp_Click(object sender, EventArgs e)
        {
            this.respiratoryBindingSource.AddNew();

            patientIDTextBoxResp.ReadOnly = false;
            dateTimeTextBoxResp.ReadOnly = false;
            pulseOxWNLComboBox.Enabled = true;
            pulseOxWNLPatientTextBox.ReadOnly = false;
            coughComboBox.Enabled = true;
            sputumComboBox.Enabled = true;
            consistencyComboBox.Enabled = true;
            colorComboBox.Enabled = true;
            ifColorOtherTextBox.ReadOnly = false;
            oxygenComboBox.Enabled = true;
            ifOxygenCannulaTextBox.ReadOnly = false;
            respiratoryRateComboBox.Enabled = true;
            respiratoryEffortComboBox.Enabled = true;
            respiratoryDyspneaTextBox.ReadOnly = false;
            respiratoryRhythmComboBox.Enabled = true;
            breathSoundsComboBox.Enabled = true;

            btnSaveResp.Enabled = true;
            btnNewResp.Enabled = false;

        }
        private void btnSaveResp_Click(object sender, EventArgs e)
        {
            if (IsRespValid())
            {
                this.Validate();
                this.respiratoryBindingSource.EndEdit();
                this.respiratoryTableAdapter.Update(this.capstone_Project_FinalDataSet);

                patientIDTextBoxResp.Clear();
                dateTimeTextBoxResp.Clear();
                pulseOxWNLComboBox.SelectedIndex = -1;
                pulseOxWNLPatientTextBox.Clear();
                coughComboBox.SelectedIndex = -1;
                sputumComboBox.SelectedIndex = -1;
                consistencyComboBox.SelectedIndex = -1;
                colorComboBox.SelectedIndex = -1;
                ifColorOtherTextBox.Clear();
                oxygenComboBox.SelectedIndex = -1;
                ifOxygenCannulaTextBox.Clear();
                respiratoryRateComboBox.SelectedIndex = -1;
                respiratoryEffortComboBox.SelectedIndex = -1;
                respiratoryDyspneaTextBox.Clear();
                respiratoryRhythmComboBox.SelectedIndex = -1;
                breathSoundsComboBox.SelectedIndex = -1;

                tsBtnSearchResp.Enabled = true;
                btnNewResp.Enabled = true;
            }
        }
        private void tsBtnSearchResp_Click(object sender, EventArgs e)
        {
            try
            {
                this.respiratoryTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet.Respiratory, tsTxtPtIDResp.Text);
                btnSaveResp.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void tsBtnBackResp_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        //////////////////////////////////////////////End Resp//////////////////////////////////////////////////////////////////////
        private void tsBtnBackNeuro_Click(object sender, EventArgs e)
        {
            Form welcomeForm = new frmWelcome();
            welcomeForm.Owner = this;
            welcomeForm.Show();
            this.Hide();
        }
        private void tsBtnSearchNeuro_Click(object sender, EventArgs e)
        {
            try
            {
                this.neurologicalTableAdapter.SearchByPtID(this.capstone_Project_FinalDataSet.Neurological, tsTxtPtIDNeuro.Text);
                btnSaveNeuro.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void btnNewNeuro_Click(object sender, EventArgs e)
        {
            this.neurologicalBindingSource.AddNew();

            patientIDTextBoxNeuro.ReadOnly = false;
            dateTimeTextBoxNeuro.ReadOnly = false;
            orientedToPERCheckBox.Enabled = true;
            orientedToPLCheckBox.Enabled = true;
            orientedToTimeCheckBox.Enabled = true;
            comSpeechComboBox.Enabled = true;
            locHeadNeckMTComboBox.Enabled = true;
            locRHandMTComboBox.Enabled = true;
            locLHandMTComboBox.Enabled = true;
            locRueMTComboBox.Enabled = true;
            locLueMTComboBox.Enabled = true;
            locRLEMTComboBox.Enabled = true;
            locLLEMTComboBox.Enabled = true;
            locHeadNeckMusStComboBox.Enabled = true;
            locRHandMusStComboBox.Enabled = true;
            locLHandMusStComboBox.Enabled = true;
            locRueMusStComboBox.Enabled = true;
            locLueMusStComboBox.Enabled = true;
            locRLEMusStComboBox.Enabled = true;
            locLLEMusStComboBox.Enabled = true;
            locHeadNeckSEComboBox.Enabled = true;
            locRHandSEComboBox.Enabled = true;
            locLHandSEComboBox.Enabled = true;
            locRueSEComboBox.Enabled = true;
            locLueSEComboBox.Enabled = true;
            locRLESEComboBox.Enabled = true;
            locLLESEComboBox.Enabled = true;
            locHeadNeckTRComboBox.Enabled = true;
            locRHandTRComboBox.Enabled = true;
            locLHandTRComboBox.Enabled = true;
            locRueTRComboBox.Enabled = true;
            locLueTRComboBox.Enabled = true;
            locRLETRComboBox.Enabled = true;
            locLLETRComboBox.Enabled = true;

            btnSaveNeuro.Enabled = true;
            btnNewNeuro.Enabled = false;
        }
        private void btnSaveNeuro_Click(object sender, EventArgs e)
        {
            if (IsNeuroValid())
            {
                this.Validate();
                this.neurologicalBindingSource.EndEdit();
                this.neurologicalTableAdapter.Update(this.capstone_Project_FinalDataSet);

                patientIDTextBoxNeuro.Clear();
                dateTimeTextBoxNeuro.Clear();
                orientedToTimeCheckBox.Enabled = true;
                comSpeechComboBox.SelectedIndex = -1;
                locHeadNeckMTComboBox.SelectedIndex = -1;
                locRHandMTComboBox.SelectedIndex = -1;
                locLHandMTComboBox.SelectedIndex = -1;
                locRueMTComboBox.SelectedIndex = -1;
                locLueMTComboBox.SelectedIndex = -1;
                locRLEMTComboBox.SelectedIndex = -1;
                locLLEMTComboBox.SelectedIndex = -1;
                locHeadNeckMusStComboBox.SelectedIndex = -1;
                locRHandMusStComboBox.SelectedIndex = -1;
                locLHandMusStComboBox.SelectedIndex = -1;
                locRueMusStComboBox.SelectedIndex = -1;
                locLueMusStComboBox.SelectedIndex = -1;
                locRLEMusStComboBox.SelectedIndex = -1;
                locLLEMusStComboBox.SelectedIndex = -1;
                locHeadNeckSEComboBox.SelectedIndex = -1;
                locRHandSEComboBox.SelectedIndex = -1;
                locLHandSEComboBox.SelectedIndex = -1;
                locRueSEComboBox.SelectedIndex = -1;
                locLueSEComboBox.SelectedIndex = -1;
                locRLESEComboBox.SelectedIndex = -1; ;
                locLLESEComboBox.SelectedIndex = -1;
                locHeadNeckTRComboBox.SelectedIndex = -1;
                locRHandTRComboBox.SelectedIndex = -1;
                locLHandTRComboBox.SelectedIndex = -1;
                locRueTRComboBox.SelectedIndex = -1;
                locLueTRComboBox.SelectedIndex = -1;
                locRLETRComboBox.SelectedIndex = -1;
                locLLETRComboBox.SelectedIndex = -1;
                btnNewNeuro.Enabled = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //////////////////////////////////////////////End Resp//////////////////////////////////////////////////////////////////////
    }
}
