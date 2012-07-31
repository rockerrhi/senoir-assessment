namespace Capstone
{
    partial class frmAssessment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label patientIDLabel8;
            System.Windows.Forms.Label dateTimeLabel9;
            System.Windows.Forms.Label patientIDLabel7;
            System.Windows.Forms.Label dateTimeLabel7;
            System.Windows.Forms.Label patientIDLabel5;
            System.Windows.Forms.Label dateTimeLabel5;
            System.Windows.Forms.Label patientIDLabel4;
            System.Windows.Forms.Label dateTimeLabel4;
            System.Windows.Forms.Label patientIDLabel3;
            System.Windows.Forms.Label dateTimeLabel3;
            System.Windows.Forms.Label patientIDLabel1;
            System.Windows.Forms.Label dateTimeLabel1;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label dateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssessment));
            this.neurologicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capstone_Project_FinalDataSet = new Capstone.Capstone_Project_FinalDataSet();
            this.respiratoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardiovascularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genitourinaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastrointestinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinIntegrityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.painBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intravenousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cast_Extremity_AssessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cast_Extremity_AssessmentTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.Cast_Extremity_AssessmentTableAdapter();
            this.tableAdapterManager = new Capstone.Capstone_Project_FinalDataSetTableAdapters.TableAdapterManager();
            this.intravenousTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.IntravenousTableAdapter();
            this.painTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.PainTableAdapter();
            this.skinIntegrityTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.SkinIntegrityTableAdapter();
            this.gastrointestinalTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.GastrointestinalTableAdapter();
            this.genitourinaryTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.GenitourinaryTableAdapter();
            this.cardiovascularTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.CardiovascularTableAdapter();
            this.respiratoryTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.RespiratoryTableAdapter();
            this.neurologicalTableAdapter = new Capstone.Capstone_Project_FinalDataSetTableAdapters.NeurologicalTableAdapter();
            this.tabpageExtrimety = new System.Windows.Forms.TabPage();
            this.cast_Extremity_AssessmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.tsbBackCast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtCastPtID = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearchCast = new System.Windows.Forms.ToolStripButton();
            this.dateTimeTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox8 = new System.Windows.Forms.TextBox();
            this.ifSwellingYesTextBox = new System.Windows.Forms.TextBox();
            this.ifPainIncreaseYesTextBox = new System.Windows.Forms.TextBox();
            this.ifDrainageYesTextBox = new System.Windows.Forms.TextBox();
            this.btnCastSave = new System.Windows.Forms.Button();
            this.btnCastNew = new System.Windows.Forms.Button();
            this.extremitySwellingComboBox = new System.Windows.Forms.ComboBox();
            this.extremityPainIncreaseComboBox = new System.Windows.Forms.ComboBox();
            this.extremitySensationComboBox = new System.Windows.Forms.ComboBox();
            this.extremityTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.extremityColorComboBox = new System.Windows.Forms.ComboBox();
            this.drainageComboBox = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabpageIV = new System.Windows.Forms.TabPage();
            this.bindingNavigatorIV = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnBackIV = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtIVPtID = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnIVSearch = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IVdateTimeTextBox = new System.Windows.Forms.TextBox();
            this.IVpatientIDTextBox = new System.Windows.Forms.TextBox();
            this.ifPCAFentanylEpiduralOtherTextBox = new System.Windows.Forms.TextBox();
            this.pCAMaxDosePerHourTextBox = new System.Windows.Forms.TextBox();
            this.pCADemandDoseTextBox = new System.Windows.Forms.TextBox();
            this.pCAContinuousDoseTextBox = new System.Windows.Forms.TextBox();
            this.iVOverHrsTextBox = new System.Windows.Forms.TextBox();
            this.iVFluidsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ifTypeLinePeripheralTextBox = new System.Windows.Forms.TextBox();
            this.btnIVSave = new System.Windows.Forms.Button();
            this.btnIVNew = new System.Windows.Forms.Button();
            this.ifPCAFentanylEpiduralComboBox = new System.Windows.Forms.ComboBox();
            this.pCAFentanylComboBox = new System.Windows.Forms.ComboBox();
            this.pCAComboBox = new System.Windows.Forms.ComboBox();
            this.iVFluidsComboBox = new System.Windows.Forms.ComboBox();
            this.insertionSiteComboBox = new System.Windows.Forms.ComboBox();
            this.typeLineComboBox = new System.Windows.Forms.ComboBox();
            this.label205 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tabpageSkin = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnBackSkin = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtPtIDSkin = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearchSkin = new System.Windows.Forms.ToolStripButton();
            this.btnSaveSkin = new System.Windows.Forms.Button();
            this.btnNewSkin = new System.Windows.Forms.Button();
            this.dateTimeTextBoxSkin = new System.Windows.Forms.TextBox();
            this.patientIDTextBoxSkin = new System.Windows.Forms.TextBox();
            this.skinisDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.contusionEcchymosisLocationsTextBox = new System.Windows.Forms.TextBox();
            this.contusionEcchymosisLengthTextBox = new System.Windows.Forms.TextBox();
            this.signsofInflammationLocationTextBox = new System.Windows.Forms.TextBox();
            this.contusionEcchymosisComboBox = new System.Windows.Forms.ComboBox();
            this.signsofInflammationComboBox = new System.Windows.Forms.ComboBox();
            this.skinIsComboBox = new System.Windows.Forms.ComboBox();
            this.skinColorComboBox = new System.Windows.Forms.ComboBox();
            this.label162 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.tabpageGastro = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.dateTimeTextBoxGastro = new System.Windows.Forms.TextBox();
            this.patientIDTextBoxGastro = new System.Windows.Forms.TextBox();
            this.tubeFeedingAmountTextBox = new System.Windows.Forms.TextBox();
            this.tubeFeedingTypeTextBox = new System.Windows.Forms.TextBox();
            this.tubesPHAspirateTextBox = new System.Windows.Forms.TextBox();
            this.lastBowelMovementOtherTextBox = new System.Windows.Forms.TextBox();
            this.bowelMovementsOtherTextBox = new System.Windows.Forms.TextBox();
            this.abdominalGirthTextBox = new System.Windows.Forms.TextBox();
            this.btnNewGastro = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnBackGastro = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtPtIDGastro = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearchGastro = new System.Windows.Forms.ToolStripButton();
            this.btnSaveGastro = new System.Windows.Forms.Button();
            this.stomaStatusComboBox = new System.Windows.Forms.ComboBox();
            this.stomaComboBox = new System.Windows.Forms.ComboBox();
            this.tubeFeedingComboBox = new System.Windows.Forms.ComboBox();
            this.insertionSiteComboBox1 = new System.Windows.Forms.ComboBox();
            this.tubesComboBox = new System.Windows.Forms.ComboBox();
            this.bowelSoundsComboBox = new System.Windows.Forms.ComboBox();
            this.nutritionalIntakeComboBox = new System.Windows.Forms.ComboBox();
            this.continentComboBox = new System.Windows.Forms.ComboBox();
            this.lastBowelMovementComboBox = new System.Windows.Forms.ComboBox();
            this.bowelMovementsComboBox = new System.Windows.Forms.ComboBox();
            this.abdomenComboBox = new System.Windows.Forms.ComboBox();
            this.tongueComboBox = new System.Windows.Forms.ComboBox();
            this.oralMucosaComboBox = new System.Windows.Forms.ComboBox();
            this.label124 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.tabpageUrinary = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnBack = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtPtIDGenit = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearchGenit = new System.Windows.Forms.ToolStripButton();
            this.btnSaveGenit = new System.Windows.Forms.Button();
            this.btnNewGenit = new System.Windows.Forms.Button();
            this.dateTimeTextBoxGenit = new System.Windows.Forms.TextBox();
            this.patientIDTextBoxGenit = new System.Windows.Forms.TextBox();
            this.ifGenitaliaAbnormalitiesTextBox = new System.Windows.Forms.TextBox();
            this.insertionSiteComboBox2 = new System.Windows.Forms.ComboBox();
            this.urinaryCatheterComboBox = new System.Windows.Forms.ComboBox();
            this.urinaryStentsComboBox = new System.Windows.Forms.ComboBox();
            this.stomaStatusComboBox1 = new System.Windows.Forms.ComboBox();
            this.urostomyComboBox = new System.Windows.Forms.ComboBox();
            this.urineCharComboBox = new System.Windows.Forms.ComboBox();
            this.urineColorComboBox = new System.Windows.Forms.ComboBox();
            this.urineAmountComboBox = new System.Windows.Forms.ComboBox();
            this.continentGenComboBox = new System.Windows.Forms.ComboBox();
            this.urinationAssessmentComboBox = new System.Windows.Forms.ComboBox();
            this.genitaliaComboBox = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabpageRespiratory = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem7 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnBackResp = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem7 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtPtIDResp = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearchResp = new System.Windows.Forms.ToolStripButton();
            this.btnNewResp = new System.Windows.Forms.Button();
            this.btnSaveResp = new System.Windows.Forms.Button();
            this.dateTimeTextBoxResp = new System.Windows.Forms.TextBox();
            this.patientIDTextBoxResp = new System.Windows.Forms.TextBox();
            this.respiratoryDyspneaTextBox = new System.Windows.Forms.TextBox();
            this.ifOxygenCannulaTextBox = new System.Windows.Forms.TextBox();
            this.ifColorOtherTextBox = new System.Windows.Forms.TextBox();
            this.pulseOxWNLPatientTextBox = new System.Windows.Forms.TextBox();
            this.breathSoundsComboBox = new System.Windows.Forms.ComboBox();
            this.respiratoryRhythmComboBox = new System.Windows.Forms.ComboBox();
            this.respiratoryEffortComboBox = new System.Windows.Forms.ComboBox();
            this.respiratoryRateComboBox = new System.Windows.Forms.ComboBox();
            this.oxygenComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.consistencyComboBox = new System.Windows.Forms.ComboBox();
            this.sputumComboBox = new System.Windows.Forms.ComboBox();
            this.coughComboBox = new System.Windows.Forms.ComboBox();
            this.pulseOxWNLComboBox = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabpageNeuro = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingNavigator6 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem8 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnBackNeuro = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem8 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtPtIDNeuro = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearchNeuro = new System.Windows.Forms.ToolStripButton();
            this.btnSaveNeuro = new System.Windows.Forms.Button();
            this.btnNewNeuro = new System.Windows.Forms.Button();
            this.dateTimeTextBoxNeuro = new System.Windows.Forms.TextBox();
            this.patientIDTextBoxNeuro = new System.Windows.Forms.TextBox();
            this.locLLETRComboBox = new System.Windows.Forms.ComboBox();
            this.locRLETRComboBox = new System.Windows.Forms.ComboBox();
            this.locLueTRComboBox = new System.Windows.Forms.ComboBox();
            this.locRueTRComboBox = new System.Windows.Forms.ComboBox();
            this.locLHandTRComboBox = new System.Windows.Forms.ComboBox();
            this.locRHandTRComboBox = new System.Windows.Forms.ComboBox();
            this.locHeadNeckTRComboBox = new System.Windows.Forms.ComboBox();
            this.locLLESEComboBox = new System.Windows.Forms.ComboBox();
            this.locRLESEComboBox = new System.Windows.Forms.ComboBox();
            this.locLueSEComboBox = new System.Windows.Forms.ComboBox();
            this.locRueSEComboBox = new System.Windows.Forms.ComboBox();
            this.locLHandSEComboBox = new System.Windows.Forms.ComboBox();
            this.locRHandSEComboBox = new System.Windows.Forms.ComboBox();
            this.locHeadNeckSEComboBox = new System.Windows.Forms.ComboBox();
            this.locLLEMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locRLEMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locLueMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locRueMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locLHandMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locRHandMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locHeadNeckMusStComboBox = new System.Windows.Forms.ComboBox();
            this.locLLEMTComboBox = new System.Windows.Forms.ComboBox();
            this.locRLEMTComboBox = new System.Windows.Forms.ComboBox();
            this.locLueMTComboBox = new System.Windows.Forms.ComboBox();
            this.locRueMTComboBox = new System.Windows.Forms.ComboBox();
            this.locLHandMTComboBox = new System.Windows.Forms.ComboBox();
            this.locRHandMTComboBox = new System.Windows.Forms.ComboBox();
            this.locHeadNeckMTComboBox = new System.Windows.Forms.ComboBox();
            this.comSpeechComboBox = new System.Windows.Forms.ComboBox();
            this.orientedToTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.orientedToPLCheckBox = new System.Windows.Forms.CheckBox();
            this.orientedToPERCheckBox = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnExit = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            patientIDLabel8 = new System.Windows.Forms.Label();
            dateTimeLabel9 = new System.Windows.Forms.Label();
            patientIDLabel7 = new System.Windows.Forms.Label();
            dateTimeLabel7 = new System.Windows.Forms.Label();
            patientIDLabel5 = new System.Windows.Forms.Label();
            dateTimeLabel5 = new System.Windows.Forms.Label();
            patientIDLabel4 = new System.Windows.Forms.Label();
            dateTimeLabel4 = new System.Windows.Forms.Label();
            patientIDLabel3 = new System.Windows.Forms.Label();
            dateTimeLabel3 = new System.Windows.Forms.Label();
            patientIDLabel1 = new System.Windows.Forms.Label();
            dateTimeLabel1 = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.neurologicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstone_Project_FinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiratoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardiovascularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genitourinaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastrointestinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinIntegrityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intravenousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cast_Extremity_AssessmentBindingSource)).BeginInit();
            this.tabpageExtrimety.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cast_Extremity_AssessmentBindingNavigator)).BeginInit();
            this.cast_Extremity_AssessmentBindingNavigator.SuspendLayout();
            this.tabpageIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorIV)).BeginInit();
            this.bindingNavigatorIV.SuspendLayout();
            this.tabpageSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabpageGastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabpageUrinary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.tabpageRespiratory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            this.tabpageNeuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).BeginInit();
            this.bindingNavigator6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIDLabel8
            // 
            patientIDLabel8.AutoSize = true;
            patientIDLabel8.Location = new System.Drawing.Point(140, 93);
            patientIDLabel8.Name = "patientIDLabel8";
            patientIDLabel8.Size = new System.Drawing.Size(57, 13);
            patientIDLabel8.TabIndex = 84;
            patientIDLabel8.Text = "Patient ID:";
            // 
            // dateTimeLabel9
            // 
            dateTimeLabel9.AutoSize = true;
            dateTimeLabel9.Location = new System.Drawing.Point(341, 93);
            dateTimeLabel9.Name = "dateTimeLabel9";
            dateTimeLabel9.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel9.TabIndex = 88;
            dateTimeLabel9.Text = "Date Time:";
            // 
            // patientIDLabel7
            // 
            patientIDLabel7.AutoSize = true;
            patientIDLabel7.Location = new System.Drawing.Point(131, 56);
            patientIDLabel7.Name = "patientIDLabel7";
            patientIDLabel7.Size = new System.Drawing.Size(57, 13);
            patientIDLabel7.TabIndex = 182;
            patientIDLabel7.Text = "Patient ID:";
            // 
            // dateTimeLabel7
            // 
            dateTimeLabel7.AutoSize = true;
            dateTimeLabel7.Location = new System.Drawing.Point(348, 56);
            dateTimeLabel7.Name = "dateTimeLabel7";
            dateTimeLabel7.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel7.TabIndex = 183;
            dateTimeLabel7.Text = "Date Time:";
            // 
            // patientIDLabel5
            // 
            patientIDLabel5.AutoSize = true;
            patientIDLabel5.Location = new System.Drawing.Point(138, 58);
            patientIDLabel5.Name = "patientIDLabel5";
            patientIDLabel5.Size = new System.Drawing.Size(57, 13);
            patientIDLabel5.TabIndex = 182;
            patientIDLabel5.Text = "Patient ID:";
            // 
            // dateTimeLabel5
            // 
            dateTimeLabel5.AutoSize = true;
            dateTimeLabel5.Location = new System.Drawing.Point(342, 58);
            dateTimeLabel5.Name = "dateTimeLabel5";
            dateTimeLabel5.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel5.TabIndex = 183;
            dateTimeLabel5.Text = "Date Time:";
            // 
            // patientIDLabel4
            // 
            patientIDLabel4.AutoSize = true;
            patientIDLabel4.Location = new System.Drawing.Point(151, 59);
            patientIDLabel4.Name = "patientIDLabel4";
            patientIDLabel4.Size = new System.Drawing.Size(57, 13);
            patientIDLabel4.TabIndex = 183;
            patientIDLabel4.Text = "Patient ID:";
            // 
            // dateTimeLabel4
            // 
            dateTimeLabel4.AutoSize = true;
            dateTimeLabel4.Location = new System.Drawing.Point(325, 59);
            dateTimeLabel4.Name = "dateTimeLabel4";
            dateTimeLabel4.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel4.TabIndex = 184;
            dateTimeLabel4.Text = "Date Time:";
            // 
            // patientIDLabel3
            // 
            patientIDLabel3.AutoSize = true;
            patientIDLabel3.Location = new System.Drawing.Point(147, 75);
            patientIDLabel3.Name = "patientIDLabel3";
            patientIDLabel3.Size = new System.Drawing.Size(57, 13);
            patientIDLabel3.TabIndex = 184;
            patientIDLabel3.Text = "Patient ID:";
            // 
            // dateTimeLabel3
            // 
            dateTimeLabel3.AutoSize = true;
            dateTimeLabel3.Location = new System.Drawing.Point(333, 75);
            dateTimeLabel3.Name = "dateTimeLabel3";
            dateTimeLabel3.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel3.TabIndex = 185;
            dateTimeLabel3.Text = "Date Time:";
            // 
            // patientIDLabel1
            // 
            patientIDLabel1.AutoSize = true;
            patientIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientIDLabel1.Location = new System.Drawing.Point(136, 66);
            patientIDLabel1.Name = "patientIDLabel1";
            patientIDLabel1.Size = new System.Drawing.Size(57, 13);
            patientIDLabel1.TabIndex = 188;
            patientIDLabel1.Text = "Patient ID:";
            // 
            // dateTimeLabel1
            // 
            dateTimeLabel1.AutoSize = true;
            dateTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimeLabel1.Location = new System.Drawing.Point(323, 66);
            dateTimeLabel1.Name = "dateTimeLabel1";
            dateTimeLabel1.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel1.TabIndex = 189;
            dateTimeLabel1.Text = "Date Time:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(120, 46);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 204;
            patientIDLabel.Text = "Patient ID:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new System.Drawing.Point(308, 46);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel.TabIndex = 205;
            dateTimeLabel.Text = "Date Time:";
            // 
            // neurologicalBindingSource
            // 
            this.neurologicalBindingSource.DataMember = "Neurological";
            this.neurologicalBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // capstone_Project_FinalDataSet
            // 
            this.capstone_Project_FinalDataSet.DataSetName = "Capstone_Project_FinalDataSet";
            this.capstone_Project_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // respiratoryBindingSource
            // 
            this.respiratoryBindingSource.DataMember = "Respiratory";
            this.respiratoryBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // cardiovascularBindingSource
            // 
            this.cardiovascularBindingSource.DataMember = "Cardiovascular";
            this.cardiovascularBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // genitourinaryBindingSource
            // 
            this.genitourinaryBindingSource.DataMember = "Genitourinary";
            this.genitourinaryBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // gastrointestinalBindingSource
            // 
            this.gastrointestinalBindingSource.DataMember = "Gastrointestinal";
            this.gastrointestinalBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // skinIntegrityBindingSource
            // 
            this.skinIntegrityBindingSource.DataMember = "SkinIntegrity";
            this.skinIntegrityBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // painBindingSource
            // 
            this.painBindingSource.DataMember = "Pain";
            this.painBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // intravenousBindingSource
            // 
            this.intravenousBindingSource.DataMember = "Intravenous";
            this.intravenousBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // cast_Extremity_AssessmentBindingSource
            // 
            this.cast_Extremity_AssessmentBindingSource.DataMember = "Cast/Extremity Assessment";
            this.cast_Extremity_AssessmentBindingSource.DataSource = this.capstone_Project_FinalDataSet;
            // 
            // cast_Extremity_AssessmentTableAdapter
            // 
            this.cast_Extremity_AssessmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardiovascularTableAdapter = null;
            this.tableAdapterManager.Cast_Extremity_AssessmentTableAdapter = this.cast_Extremity_AssessmentTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.GastrointestinalTableAdapter = null;
            this.tableAdapterManager.GenitourinaryTableAdapter = null;
            this.tableAdapterManager.IntravenousTableAdapter = null;
            this.tableAdapterManager.NeurologicalTableAdapter = null;
            this.tableAdapterManager.PainTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.RespiratoryTableAdapter = null;
            this.tableAdapterManager.SkinIntegrityTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Capstone.Capstone_Project_FinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // intravenousTableAdapter
            // 
            this.intravenousTableAdapter.ClearBeforeFill = true;
            // 
            // painTableAdapter
            // 
            this.painTableAdapter.ClearBeforeFill = true;
            // 
            // skinIntegrityTableAdapter
            // 
            this.skinIntegrityTableAdapter.ClearBeforeFill = true;
            // 
            // gastrointestinalTableAdapter
            // 
            this.gastrointestinalTableAdapter.ClearBeforeFill = true;
            // 
            // genitourinaryTableAdapter
            // 
            this.genitourinaryTableAdapter.ClearBeforeFill = true;
            // 
            // cardiovascularTableAdapter
            // 
            this.cardiovascularTableAdapter.ClearBeforeFill = true;
            // 
            // respiratoryTableAdapter
            // 
            this.respiratoryTableAdapter.ClearBeforeFill = true;
            // 
            // neurologicalTableAdapter
            // 
            this.neurologicalTableAdapter.ClearBeforeFill = true;
            // 
            // tabpageExtrimety
            // 
            this.tabpageExtrimety.AutoScroll = true;
            this.tabpageExtrimety.Controls.Add(this.label39);
            this.tabpageExtrimety.Controls.Add(this.cast_Extremity_AssessmentBindingNavigator);
            this.tabpageExtrimety.Controls.Add(dateTimeLabel9);
            this.tabpageExtrimety.Controls.Add(this.dateTimeTextBox);
            this.tabpageExtrimety.Controls.Add(this.patientIDTextBox8);
            this.tabpageExtrimety.Controls.Add(this.ifSwellingYesTextBox);
            this.tabpageExtrimety.Controls.Add(this.ifPainIncreaseYesTextBox);
            this.tabpageExtrimety.Controls.Add(this.ifDrainageYesTextBox);
            this.tabpageExtrimety.Controls.Add(this.btnCastSave);
            this.tabpageExtrimety.Controls.Add(this.btnCastNew);
            this.tabpageExtrimety.Controls.Add(patientIDLabel8);
            this.tabpageExtrimety.Controls.Add(this.extremitySwellingComboBox);
            this.tabpageExtrimety.Controls.Add(this.extremityPainIncreaseComboBox);
            this.tabpageExtrimety.Controls.Add(this.extremitySensationComboBox);
            this.tabpageExtrimety.Controls.Add(this.extremityTemperatureComboBox);
            this.tabpageExtrimety.Controls.Add(this.extremityColorComboBox);
            this.tabpageExtrimety.Controls.Add(this.drainageComboBox);
            this.tabpageExtrimety.Controls.Add(this.label98);
            this.tabpageExtrimety.Controls.Add(this.label97);
            this.tabpageExtrimety.Controls.Add(this.label96);
            this.tabpageExtrimety.Controls.Add(this.label23);
            this.tabpageExtrimety.Controls.Add(this.label22);
            this.tabpageExtrimety.Controls.Add(this.label21);
            this.tabpageExtrimety.Controls.Add(this.label20);
            this.tabpageExtrimety.Controls.Add(this.label19);
            this.tabpageExtrimety.Controls.Add(this.label18);
            this.tabpageExtrimety.Controls.Add(this.label17);
            this.tabpageExtrimety.Location = new System.Drawing.Point(4, 22);
            this.tabpageExtrimety.Name = "tabpageExtrimety";
            this.tabpageExtrimety.Size = new System.Drawing.Size(645, 528);
            this.tabpageExtrimety.TabIndex = 8;
            this.tabpageExtrimety.Text = "Cast/Extremity";
            this.tabpageExtrimety.UseVisualStyleBackColor = true;
            // 
            // cast_Extremity_AssessmentBindingNavigator
            // 
            this.cast_Extremity_AssessmentBindingNavigator.AddNewItem = null;
            this.cast_Extremity_AssessmentBindingNavigator.BindingSource = this.cast_Extremity_AssessmentBindingSource;
            this.cast_Extremity_AssessmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cast_Extremity_AssessmentBindingNavigator.DeleteItem = null;
            this.cast_Extremity_AssessmentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cast_Extremity_AssessmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBackCast,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tslSearch,
            this.tsTxtCastPtID,
            this.tsBtnSearchCast});
            this.cast_Extremity_AssessmentBindingNavigator.Location = new System.Drawing.Point(0, 503);
            this.cast_Extremity_AssessmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cast_Extremity_AssessmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cast_Extremity_AssessmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cast_Extremity_AssessmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cast_Extremity_AssessmentBindingNavigator.Name = "cast_Extremity_AssessmentBindingNavigator";
            this.cast_Extremity_AssessmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cast_Extremity_AssessmentBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.cast_Extremity_AssessmentBindingNavigator.TabIndex = 90;
            this.cast_Extremity_AssessmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // tsbBackCast
            // 
            this.tsbBackCast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBackCast.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackCast.Image")));
            this.tsbBackCast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackCast.Name = "tsbBackCast";
            this.tsbBackCast.Size = new System.Drawing.Size(36, 22);
            this.tsbBackCast.Text = "Back";
            this.tsbBackCast.Click += new System.EventHandler(this.tsbBackCast_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSearch
            // 
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(61, 22);
            this.tslSearch.Text = "Patient ID:";
            // 
            // tsTxtCastPtID
            // 
            this.tsTxtCastPtID.Name = "tsTxtCastPtID";
            this.tsTxtCastPtID.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnSearchCast
            // 
            this.tsBtnSearchCast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearchCast.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearchCast.Image")));
            this.tsBtnSearchCast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearchCast.Name = "tsBtnSearchCast";
            this.tsBtnSearchCast.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSearchCast.Text = "Search";
            this.tsBtnSearchCast.Click += new System.EventHandler(this.tsBtnSearchCast_Click);
            // 
            // dateTimeTextBox
            // 
            this.dateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "DateTime", true));
            this.dateTimeTextBox.Location = new System.Drawing.Point(406, 89);
            this.dateTimeTextBox.Name = "dateTimeTextBox";
            this.dateTimeTextBox.ReadOnly = true;
            this.dateTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTextBox.TabIndex = 2;
            this.dateTimeTextBox.Tag = "Date + Time";
            // 
            // patientIDTextBox8
            // 
            this.patientIDTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "PatientID", true));
            this.patientIDTextBox8.Location = new System.Drawing.Point(203, 89);
            this.patientIDTextBox8.Name = "patientIDTextBox8";
            this.patientIDTextBox8.ReadOnly = true;
            this.patientIDTextBox8.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox8.TabIndex = 1;
            this.patientIDTextBox8.Tag = "Patient ID";
            // 
            // ifSwellingYesTextBox
            // 
            this.ifSwellingYesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "IfSwellingYes", true));
            this.ifSwellingYesTextBox.Location = new System.Drawing.Point(406, 272);
            this.ifSwellingYesTextBox.Name = "ifSwellingYesTextBox";
            this.ifSwellingYesTextBox.ReadOnly = true;
            this.ifSwellingYesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifSwellingYesTextBox.TabIndex = 11;
            // 
            // ifPainIncreaseYesTextBox
            // 
            this.ifPainIncreaseYesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "IfPainIncreaseYes", true));
            this.ifPainIncreaseYesTextBox.Location = new System.Drawing.Point(406, 246);
            this.ifPainIncreaseYesTextBox.Name = "ifPainIncreaseYesTextBox";
            this.ifPainIncreaseYesTextBox.ReadOnly = true;
            this.ifPainIncreaseYesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifPainIncreaseYesTextBox.TabIndex = 9;
            // 
            // ifDrainageYesTextBox
            // 
            this.ifDrainageYesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "IfDrainageYes", true));
            this.ifDrainageYesTextBox.Location = new System.Drawing.Point(406, 126);
            this.ifDrainageYesTextBox.Name = "ifDrainageYesTextBox";
            this.ifDrainageYesTextBox.ReadOnly = true;
            this.ifDrainageYesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifDrainageYesTextBox.TabIndex = 4;
            // 
            // btnCastSave
            // 
            this.btnCastSave.Location = new System.Drawing.Point(292, 318);
            this.btnCastSave.Name = "btnCastSave";
            this.btnCastSave.Size = new System.Drawing.Size(75, 23);
            this.btnCastSave.TabIndex = 12;
            this.btnCastSave.Text = "Save";
            this.btnCastSave.UseVisualStyleBackColor = true;
            this.btnCastSave.Click += new System.EventHandler(this.btnCastSave_Click);
            // 
            // btnCastNew
            // 
            this.btnCastNew.Location = new System.Drawing.Point(294, 38);
            this.btnCastNew.Name = "btnCastNew";
            this.btnCastNew.Size = new System.Drawing.Size(75, 23);
            this.btnCastNew.TabIndex = 0;
            this.btnCastNew.Text = "New";
            this.btnCastNew.UseVisualStyleBackColor = true;
            this.btnCastNew.Click += new System.EventHandler(this.btnCastNew_Click);
            // 
            // extremitySwellingComboBox
            // 
            this.extremitySwellingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "ExtremitySwelling", true));
            this.extremitySwellingComboBox.Enabled = false;
            this.extremitySwellingComboBox.FormattingEnabled = true;
            this.extremitySwellingComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.extremitySwellingComboBox.Location = new System.Drawing.Point(246, 272);
            this.extremitySwellingComboBox.Name = "extremitySwellingComboBox";
            this.extremitySwellingComboBox.Size = new System.Drawing.Size(56, 21);
            this.extremitySwellingComboBox.TabIndex = 10;
            // 
            // extremityPainIncreaseComboBox
            // 
            this.extremityPainIncreaseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "ExtremityPainIncrease", true));
            this.extremityPainIncreaseComboBox.Enabled = false;
            this.extremityPainIncreaseComboBox.FormattingEnabled = true;
            this.extremityPainIncreaseComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.extremityPainIncreaseComboBox.Location = new System.Drawing.Point(246, 245);
            this.extremityPainIncreaseComboBox.Name = "extremityPainIncreaseComboBox";
            this.extremityPainIncreaseComboBox.Size = new System.Drawing.Size(56, 21);
            this.extremityPainIncreaseComboBox.TabIndex = 8;
            // 
            // extremitySensationComboBox
            // 
            this.extremitySensationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "ExtremitySensation", true));
            this.extremitySensationComboBox.Enabled = false;
            this.extremitySensationComboBox.FormattingEnabled = true;
            this.extremitySensationComboBox.Items.AddRange(new object[] {
            "WNL",
            "Loss of sensation"});
            this.extremitySensationComboBox.Location = new System.Drawing.Point(246, 218);
            this.extremitySensationComboBox.Name = "extremitySensationComboBox";
            this.extremitySensationComboBox.Size = new System.Drawing.Size(121, 21);
            this.extremitySensationComboBox.TabIndex = 7;
            // 
            // extremityTemperatureComboBox
            // 
            this.extremityTemperatureComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "ExtremityTemperature", true));
            this.extremityTemperatureComboBox.Enabled = false;
            this.extremityTemperatureComboBox.FormattingEnabled = true;
            this.extremityTemperatureComboBox.Items.AddRange(new object[] {
            "Warm",
            "Cool"});
            this.extremityTemperatureComboBox.Location = new System.Drawing.Point(246, 191);
            this.extremityTemperatureComboBox.Name = "extremityTemperatureComboBox";
            this.extremityTemperatureComboBox.Size = new System.Drawing.Size(121, 21);
            this.extremityTemperatureComboBox.TabIndex = 6;
            // 
            // extremityColorComboBox
            // 
            this.extremityColorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "ExtremityColor", true));
            this.extremityColorComboBox.Enabled = false;
            this.extremityColorComboBox.FormattingEnabled = true;
            this.extremityColorComboBox.Items.AddRange(new object[] {
            "WNL",
            "Pale"});
            this.extremityColorComboBox.Location = new System.Drawing.Point(246, 164);
            this.extremityColorComboBox.Name = "extremityColorComboBox";
            this.extremityColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.extremityColorComboBox.TabIndex = 5;
            // 
            // drainageComboBox
            // 
            this.drainageComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cast_Extremity_AssessmentBindingSource, "Drainage", true));
            this.drainageComboBox.Enabled = false;
            this.drainageComboBox.FormattingEnabled = true;
            this.drainageComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.drainageComboBox.Location = new System.Drawing.Point(246, 126);
            this.drainageComboBox.Name = "drainageComboBox";
            this.drainageComboBox.Size = new System.Drawing.Size(56, 21);
            this.drainageComboBox.TabIndex = 3;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(315, 275);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(85, 13);
            this.label98.TabIndex = 70;
            this.label98.Text = "If Yes, Describe:";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(315, 248);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(85, 13);
            this.label97.TabIndex = 69;
            this.label97.Text = "If Yes, Describe:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(315, 129);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(85, 13);
            this.label96.TabIndex = 68;
            this.label96.Text = "If Yes, Describe:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(138, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Swelling increasing?";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(156, 247);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Pain increasing?";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(184, 222);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Sensation:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(171, 197);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Temperature:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(207, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Color:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(134, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 15);
            this.label18.TabIndex = 23;
            this.label18.Text = "Extremity check";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(188, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Drainage:";
            // 
            // tabpageIV
            // 
            this.tabpageIV.AutoScroll = true;
            this.tabpageIV.Controls.Add(this.label38);
            this.tabpageIV.Controls.Add(this.bindingNavigatorIV);
            this.tabpageIV.Controls.Add(this.label8);
            this.tabpageIV.Controls.Add(this.label4);
            this.tabpageIV.Controls.Add(this.IVdateTimeTextBox);
            this.tabpageIV.Controls.Add(this.IVpatientIDTextBox);
            this.tabpageIV.Controls.Add(this.ifPCAFentanylEpiduralOtherTextBox);
            this.tabpageIV.Controls.Add(this.pCAMaxDosePerHourTextBox);
            this.tabpageIV.Controls.Add(this.pCADemandDoseTextBox);
            this.tabpageIV.Controls.Add(this.pCAContinuousDoseTextBox);
            this.tabpageIV.Controls.Add(this.iVOverHrsTextBox);
            this.tabpageIV.Controls.Add(this.iVFluidsDescriptionTextBox);
            this.tabpageIV.Controls.Add(this.ifTypeLinePeripheralTextBox);
            this.tabpageIV.Controls.Add(this.btnIVSave);
            this.tabpageIV.Controls.Add(this.btnIVNew);
            this.tabpageIV.Controls.Add(dateTimeLabel7);
            this.tabpageIV.Controls.Add(patientIDLabel7);
            this.tabpageIV.Controls.Add(this.ifPCAFentanylEpiduralComboBox);
            this.tabpageIV.Controls.Add(this.pCAFentanylComboBox);
            this.tabpageIV.Controls.Add(this.pCAComboBox);
            this.tabpageIV.Controls.Add(this.iVFluidsComboBox);
            this.tabpageIV.Controls.Add(this.insertionSiteComboBox);
            this.tabpageIV.Controls.Add(this.typeLineComboBox);
            this.tabpageIV.Controls.Add(this.label205);
            this.tabpageIV.Controls.Add(this.label202);
            this.tabpageIV.Controls.Add(this.label199);
            this.tabpageIV.Controls.Add(this.label198);
            this.tabpageIV.Controls.Add(this.label197);
            this.tabpageIV.Controls.Add(this.label196);
            this.tabpageIV.Controls.Add(this.label195);
            this.tabpageIV.Controls.Add(this.label188);
            this.tabpageIV.Controls.Add(this.label187);
            this.tabpageIV.Controls.Add(this.label186);
            this.tabpageIV.Controls.Add(this.label64);
            this.tabpageIV.Location = new System.Drawing.Point(4, 22);
            this.tabpageIV.Name = "tabpageIV";
            this.tabpageIV.Size = new System.Drawing.Size(645, 528);
            this.tabpageIV.TabIndex = 7;
            this.tabpageIV.Text = "IV";
            this.tabpageIV.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorIV
            // 
            this.bindingNavigatorIV.AddNewItem = null;
            this.bindingNavigatorIV.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorIV.DeleteItem = null;
            this.bindingNavigatorIV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorIV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackIV,
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.toolStripLabel1,
            this.tsTxtIVPtID,
            this.tsBtnIVSearch,
            this.bindingNavigatorAddNewItem});
            this.bindingNavigatorIV.Location = new System.Drawing.Point(0, 503);
            this.bindingNavigatorIV.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorIV.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorIV.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorIV.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorIV.Name = "bindingNavigatorIV";
            this.bindingNavigatorIV.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorIV.Size = new System.Drawing.Size(645, 25);
            this.bindingNavigatorIV.TabIndex = 192;
            this.bindingNavigatorIV.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // btnBackIV
            // 
            this.btnBackIV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBackIV.Image = ((System.Drawing.Image)(resources.GetObject("btnBackIV.Image")));
            this.btnBackIV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackIV.Name = "btnBackIV";
            this.btnBackIV.Size = new System.Drawing.Size(36, 22);
            this.btnBackIV.Text = "Back";
            this.btnBackIV.Click += new System.EventHandler(this.btnBackIV_Click_1);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Pt ID:";
            // 
            // tsTxtIVPtID
            // 
            this.tsTxtIVPtID.Name = "tsTxtIVPtID";
            this.tsTxtIVPtID.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnIVSearch
            // 
            this.tsBtnIVSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnIVSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnIVSearch.Image")));
            this.tsBtnIVSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnIVSearch.Name = "tsBtnIVSearch";
            this.tsBtnIVSearch.Size = new System.Drawing.Size(46, 22);
            this.tsBtnIVSearch.Text = "Search";
            this.tsBtnIVSearch.Click += new System.EventHandler(this.tsBtnIVSearch_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 191;
            this.label8.Text = "If over hours, how many?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 190;
            this.label4.Text = "If fluids, __@__ mls/hr";
            // 
            // IVdateTimeTextBox
            // 
            this.IVdateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "DateTime", true));
            this.IVdateTimeTextBox.Location = new System.Drawing.Point(413, 52);
            this.IVdateTimeTextBox.Name = "IVdateTimeTextBox";
            this.IVdateTimeTextBox.ReadOnly = true;
            this.IVdateTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.IVdateTimeTextBox.TabIndex = 2;
            this.IVdateTimeTextBox.Tag = "Date + Time";
            // 
            // IVpatientIDTextBox
            // 
            this.IVpatientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "PatientID", true));
            this.IVpatientIDTextBox.Location = new System.Drawing.Point(194, 52);
            this.IVpatientIDTextBox.Name = "IVpatientIDTextBox";
            this.IVpatientIDTextBox.ReadOnly = true;
            this.IVpatientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IVpatientIDTextBox.TabIndex = 1;
            this.IVpatientIDTextBox.Tag = "Patient ID";
            // 
            // ifPCAFentanylEpiduralOtherTextBox
            // 
            this.ifPCAFentanylEpiduralOtherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "IfPCAFentanylEpiduralOther", true));
            this.ifPCAFentanylEpiduralOtherTextBox.Location = new System.Drawing.Point(333, 244);
            this.ifPCAFentanylEpiduralOtherTextBox.Name = "ifPCAFentanylEpiduralOtherTextBox";
            this.ifPCAFentanylEpiduralOtherTextBox.ReadOnly = true;
            this.ifPCAFentanylEpiduralOtherTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifPCAFentanylEpiduralOtherTextBox.TabIndex = 12;
            // 
            // pCAMaxDosePerHourTextBox
            // 
            this.pCAMaxDosePerHourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "PCAMaxDosePerHour", true));
            this.pCAMaxDosePerHourTextBox.Location = new System.Drawing.Point(118, 334);
            this.pCAMaxDosePerHourTextBox.Name = "pCAMaxDosePerHourTextBox";
            this.pCAMaxDosePerHourTextBox.ReadOnly = true;
            this.pCAMaxDosePerHourTextBox.Size = new System.Drawing.Size(55, 20);
            this.pCAMaxDosePerHourTextBox.TabIndex = 15;
            // 
            // pCADemandDoseTextBox
            // 
            this.pCADemandDoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "PCADemandDose", true));
            this.pCADemandDoseTextBox.Location = new System.Drawing.Point(118, 308);
            this.pCADemandDoseTextBox.Name = "pCADemandDoseTextBox";
            this.pCADemandDoseTextBox.ReadOnly = true;
            this.pCADemandDoseTextBox.Size = new System.Drawing.Size(55, 20);
            this.pCADemandDoseTextBox.TabIndex = 14;
            // 
            // pCAContinuousDoseTextBox
            // 
            this.pCAContinuousDoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "PCAContinuousDose", true));
            this.pCAContinuousDoseTextBox.Location = new System.Drawing.Point(118, 283);
            this.pCAContinuousDoseTextBox.Name = "pCAContinuousDoseTextBox";
            this.pCAContinuousDoseTextBox.ReadOnly = true;
            this.pCAContinuousDoseTextBox.Size = new System.Drawing.Size(55, 20);
            this.pCAContinuousDoseTextBox.TabIndex = 13;
            // 
            // iVOverHrsTextBox
            // 
            this.iVOverHrsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "IVOverHrs", true));
            this.iVOverHrsTextBox.Location = new System.Drawing.Point(339, 179);
            this.iVOverHrsTextBox.Name = "iVOverHrsTextBox";
            this.iVOverHrsTextBox.ReadOnly = true;
            this.iVOverHrsTextBox.Size = new System.Drawing.Size(100, 20);
            this.iVOverHrsTextBox.TabIndex = 8;
            // 
            // iVFluidsDescriptionTextBox
            // 
            this.iVFluidsDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "IVFluidsDescription", true));
            this.iVFluidsDescriptionTextBox.Location = new System.Drawing.Point(339, 155);
            this.iVFluidsDescriptionTextBox.Name = "iVFluidsDescriptionTextBox";
            this.iVFluidsDescriptionTextBox.ReadOnly = true;
            this.iVFluidsDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.iVFluidsDescriptionTextBox.TabIndex = 7;
            // 
            // ifTypeLinePeripheralTextBox
            // 
            this.ifTypeLinePeripheralTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "IfTypeLinePeripheral", true));
            this.ifTypeLinePeripheralTextBox.Location = new System.Drawing.Point(339, 105);
            this.ifTypeLinePeripheralTextBox.Name = "ifTypeLinePeripheralTextBox";
            this.ifTypeLinePeripheralTextBox.ReadOnly = true;
            this.ifTypeLinePeripheralTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifTypeLinePeripheralTextBox.TabIndex = 4;
            // 
            // btnIVSave
            // 
            this.btnIVSave.Location = new System.Drawing.Point(244, 360);
            this.btnIVSave.Name = "btnIVSave";
            this.btnIVSave.Size = new System.Drawing.Size(75, 23);
            this.btnIVSave.TabIndex = 16;
            this.btnIVSave.Text = "Save";
            this.btnIVSave.UseVisualStyleBackColor = true;
            this.btnIVSave.Click += new System.EventHandler(this.btnIVSave_Click);
            // 
            // btnIVNew
            // 
            this.btnIVNew.Location = new System.Drawing.Point(242, 19);
            this.btnIVNew.Name = "btnIVNew";
            this.btnIVNew.Size = new System.Drawing.Size(75, 23);
            this.btnIVNew.TabIndex = 0;
            this.btnIVNew.Text = "New";
            this.btnIVNew.UseVisualStyleBackColor = true;
            this.btnIVNew.Click += new System.EventHandler(this.btnIVNew_Click);
            // 
            // ifPCAFentanylEpiduralComboBox
            // 
            this.ifPCAFentanylEpiduralComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "IfPCAFentanylEpidural", true));
            this.ifPCAFentanylEpiduralComboBox.Enabled = false;
            this.ifPCAFentanylEpiduralComboBox.FormattingEnabled = true;
            this.ifPCAFentanylEpiduralComboBox.Items.AddRange(new object[] {
            "D&I",
            "Other"});
            this.ifPCAFentanylEpiduralComboBox.Location = new System.Drawing.Point(164, 244);
            this.ifPCAFentanylEpiduralComboBox.Name = "ifPCAFentanylEpiduralComboBox";
            this.ifPCAFentanylEpiduralComboBox.Size = new System.Drawing.Size(68, 21);
            this.ifPCAFentanylEpiduralComboBox.TabIndex = 11;
            // 
            // pCAFentanylComboBox
            // 
            this.pCAFentanylComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "PCAFentanyl", true));
            this.pCAFentanylComboBox.Enabled = false;
            this.pCAFentanylComboBox.FormattingEnabled = true;
            this.pCAFentanylComboBox.Items.AddRange(new object[] {
            "IV",
            "Epidural, dressing"});
            this.pCAFentanylComboBox.Location = new System.Drawing.Point(165, 214);
            this.pCAFentanylComboBox.Name = "pCAFentanylComboBox";
            this.pCAFentanylComboBox.Size = new System.Drawing.Size(68, 21);
            this.pCAFentanylComboBox.TabIndex = 10;
            // 
            // pCAComboBox
            // 
            this.pCAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "PCA", true));
            this.pCAComboBox.Enabled = false;
            this.pCAComboBox.FormattingEnabled = true;
            this.pCAComboBox.Items.AddRange(new object[] {
            "N/A",
            "Morphine",
            "Dilaudid",
            "Fentanyl"});
            this.pCAComboBox.Location = new System.Drawing.Point(48, 214);
            this.pCAComboBox.Name = "pCAComboBox";
            this.pCAComboBox.Size = new System.Drawing.Size(74, 21);
            this.pCAComboBox.TabIndex = 9;
            // 
            // iVFluidsComboBox
            // 
            this.iVFluidsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "IVFluids", true));
            this.iVFluidsComboBox.Enabled = false;
            this.iVFluidsComboBox.FormattingEnabled = true;
            this.iVFluidsComboBox.Items.AddRange(new object[] {
            "N/A,heplock",
            "IV Fluids",
            "Continuous",
            "over ___ hours",
            "IV pump",
            "Dial-a-flow",
            "Gravity"});
            this.iVFluidsComboBox.Location = new System.Drawing.Point(82, 158);
            this.iVFluidsComboBox.Name = "iVFluidsComboBox";
            this.iVFluidsComboBox.Size = new System.Drawing.Size(121, 21);
            this.iVFluidsComboBox.TabIndex = 6;
            // 
            // insertionSiteComboBox
            // 
            this.insertionSiteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "InsertionSite", true));
            this.insertionSiteComboBox.Enabled = false;
            this.insertionSiteComboBox.FormattingEnabled = true;
            this.insertionSiteComboBox.Items.AddRange(new object[] {
            "WNL",
            "Redness",
            "Tenderness/pain",
            "Warmth",
            "Swelling",
            "Drainage"});
            this.insertionSiteComboBox.Location = new System.Drawing.Point(82, 131);
            this.insertionSiteComboBox.Name = "insertionSiteComboBox";
            this.insertionSiteComboBox.Size = new System.Drawing.Size(121, 21);
            this.insertionSiteComboBox.TabIndex = 5;
            // 
            // typeLineComboBox
            // 
            this.typeLineComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.intravenousBindingSource, "TypeLine", true));
            this.typeLineComboBox.Enabled = false;
            this.typeLineComboBox.FormattingEnabled = true;
            this.typeLineComboBox.Items.AddRange(new object[] {
            "Peripheral",
            "Triple lumen CVL",
            "PICC",
            "Tunneled CVL",
            "Implanted port"});
            this.typeLineComboBox.Location = new System.Drawing.Point(82, 104);
            this.typeLineComboBox.Name = "typeLineComboBox";
            this.typeLineComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeLineComboBox.TabIndex = 3;
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.Location = new System.Drawing.Point(14, 336);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(100, 13);
            this.label205.TabIndex = 145;
            this.label205.Text = "Max doses per hour";
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(14, 312);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(73, 13);
            this.label202.TabIndex = 140;
            this.label202.Text = "Demand dose";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(14, 286);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(88, 13);
            this.label199.TabIndex = 137;
            this.label199.Text = "Continuous Dose";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label198.Location = new System.Drawing.Point(238, 248);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(89, 13);
            this.label198.TabIndex = 134;
            this.label198.Text = "If other, describe:";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label197.Location = new System.Drawing.Point(14, 248);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(119, 13);
            this.label197.TabIndex = 132;
            this.label197.Text = "Epidural Dressing Type:";
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label196.Location = new System.Drawing.Point(138, 218);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(21, 13);
            this.label196.TabIndex = 130;
            this.label196.Text = "via";
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label195.Location = new System.Drawing.Point(14, 218);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(28, 13);
            this.label195.TabIndex = 128;
            this.label195.Text = "PCA";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label188.Location = new System.Drawing.Point(14, 163);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(44, 13);
            this.label188.TabIndex = 117;
            this.label188.Text = "IV fluids";
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label187.Location = new System.Drawing.Point(14, 135);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(66, 13);
            this.label187.TabIndex = 115;
            this.label187.Text = "Insertion site";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label186.Location = new System.Drawing.Point(208, 108);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(111, 13);
            this.label186.TabIndex = 114;
            this.label186.Text = "If peripheral, describe:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(14, 107);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(62, 13);
            this.label64.TabIndex = 109;
            this.label64.Text = "Type of line";
            // 
            // tabpageSkin
            // 
            this.tabpageSkin.AutoScroll = true;
            this.tabpageSkin.Controls.Add(this.label37);
            this.tabpageSkin.Controls.Add(this.bindingNavigator1);
            this.tabpageSkin.Controls.Add(this.btnSaveSkin);
            this.tabpageSkin.Controls.Add(this.btnNewSkin);
            this.tabpageSkin.Controls.Add(this.dateTimeTextBoxSkin);
            this.tabpageSkin.Controls.Add(this.patientIDTextBoxSkin);
            this.tabpageSkin.Controls.Add(this.skinisDescriptionTextBox);
            this.tabpageSkin.Controls.Add(this.contusionEcchymosisLocationsTextBox);
            this.tabpageSkin.Controls.Add(this.contusionEcchymosisLengthTextBox);
            this.tabpageSkin.Controls.Add(this.signsofInflammationLocationTextBox);
            this.tabpageSkin.Controls.Add(dateTimeLabel5);
            this.tabpageSkin.Controls.Add(patientIDLabel5);
            this.tabpageSkin.Controls.Add(this.contusionEcchymosisComboBox);
            this.tabpageSkin.Controls.Add(this.signsofInflammationComboBox);
            this.tabpageSkin.Controls.Add(this.skinIsComboBox);
            this.tabpageSkin.Controls.Add(this.skinColorComboBox);
            this.tabpageSkin.Controls.Add(this.label162);
            this.tabpageSkin.Controls.Add(this.label161);
            this.tabpageSkin.Controls.Add(this.label160);
            this.tabpageSkin.Controls.Add(this.label159);
            this.tabpageSkin.Controls.Add(this.label158);
            this.tabpageSkin.Controls.Add(this.label157);
            this.tabpageSkin.Controls.Add(this.label156);
            this.tabpageSkin.Controls.Add(this.label154);
            this.tabpageSkin.Location = new System.Drawing.Point(4, 22);
            this.tabpageSkin.Name = "tabpageSkin";
            this.tabpageSkin.Size = new System.Drawing.Size(645, 528);
            this.tabpageSkin.TabIndex = 5;
            this.tabpageSkin.Text = "Skin Integrity";
            this.tabpageSkin.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(353, 78);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(154, 13);
            this.label37.TabIndex = 211;
            this.label37.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBackSkin,
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.toolStripLabel2,
            this.tsTxtPtIDSkin,
            this.tsBtnSearchSkin});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 503);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator1.Size = new System.Drawing.Size(645, 25);
            this.bindingNavigator1.TabIndex = 188;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem3.Text = "of {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Total number of items";
            // 
            // tsBtnBackSkin
            // 
            this.tsBtnBackSkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBackSkin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBackSkin.Image")));
            this.tsBtnBackSkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackSkin.Name = "tsBtnBackSkin";
            this.tsBtnBackSkin.Size = new System.Drawing.Size(36, 22);
            this.tsBtnBackSkin.Text = "Back";
            this.tsBtnBackSkin.Click += new System.EventHandler(this.tsBtnBackSkin_Click);
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Move previous";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Position";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Move last";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "Pt ID:";
            // 
            // tsTxtPtIDSkin
            // 
            this.tsTxtPtIDSkin.Name = "tsTxtPtIDSkin";
            this.tsTxtPtIDSkin.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnSearchSkin
            // 
            this.tsBtnSearchSkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearchSkin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearchSkin.Image")));
            this.tsBtnSearchSkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearchSkin.Name = "tsBtnSearchSkin";
            this.tsBtnSearchSkin.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSearchSkin.Text = "Search";
            this.tsBtnSearchSkin.Click += new System.EventHandler(this.tsBtnSearchSkin_Click);
            // 
            // btnSaveSkin
            // 
            this.btnSaveSkin.Location = new System.Drawing.Point(285, 284);
            this.btnSaveSkin.Name = "btnSaveSkin";
            this.btnSaveSkin.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSkin.TabIndex = 11;
            this.btnSaveSkin.Text = "Save";
            this.btnSaveSkin.UseVisualStyleBackColor = true;
            this.btnSaveSkin.Click += new System.EventHandler(this.btnSaveSkin_Click);
            // 
            // btnNewSkin
            // 
            this.btnNewSkin.Location = new System.Drawing.Point(285, 17);
            this.btnNewSkin.Name = "btnNewSkin";
            this.btnNewSkin.Size = new System.Drawing.Size(75, 23);
            this.btnNewSkin.TabIndex = 0;
            this.btnNewSkin.Text = "New";
            this.btnNewSkin.UseVisualStyleBackColor = true;
            this.btnNewSkin.Click += new System.EventHandler(this.btnNewSkin_Click);
            // 
            // dateTimeTextBoxSkin
            // 
            this.dateTimeTextBoxSkin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "DateTime", true));
            this.dateTimeTextBoxSkin.Location = new System.Drawing.Point(407, 55);
            this.dateTimeTextBoxSkin.Name = "dateTimeTextBoxSkin";
            this.dateTimeTextBoxSkin.ReadOnly = true;
            this.dateTimeTextBoxSkin.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTextBoxSkin.TabIndex = 2;
            this.dateTimeTextBoxSkin.Tag = "Date + Time";
            // 
            // patientIDTextBoxSkin
            // 
            this.patientIDTextBoxSkin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "PatientID", true));
            this.patientIDTextBoxSkin.Location = new System.Drawing.Point(201, 55);
            this.patientIDTextBoxSkin.Name = "patientIDTextBoxSkin";
            this.patientIDTextBoxSkin.ReadOnly = true;
            this.patientIDTextBoxSkin.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBoxSkin.TabIndex = 1;
            this.patientIDTextBoxSkin.Tag = "Patient ID";
            // 
            // skinisDescriptionTextBox
            // 
            this.skinisDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "SkinisDescription", true));
            this.skinisDescriptionTextBox.Location = new System.Drawing.Point(253, 131);
            this.skinisDescriptionTextBox.Name = "skinisDescriptionTextBox";
            this.skinisDescriptionTextBox.ReadOnly = true;
            this.skinisDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.skinisDescriptionTextBox.TabIndex = 5;
            // 
            // contusionEcchymosisLocationsTextBox
            // 
            this.contusionEcchymosisLocationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "ContusionEcchymosisLocations", true));
            this.contusionEcchymosisLocationsTextBox.Location = new System.Drawing.Point(76, 254);
            this.contusionEcchymosisLocationsTextBox.Name = "contusionEcchymosisLocationsTextBox";
            this.contusionEcchymosisLocationsTextBox.ReadOnly = true;
            this.contusionEcchymosisLocationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.contusionEcchymosisLocationsTextBox.TabIndex = 10;
            // 
            // contusionEcchymosisLengthTextBox
            // 
            this.contusionEcchymosisLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "ContusionEcchymosisLength", true));
            this.contusionEcchymosisLengthTextBox.Location = new System.Drawing.Point(76, 230);
            this.contusionEcchymosisLengthTextBox.Name = "contusionEcchymosisLengthTextBox";
            this.contusionEcchymosisLengthTextBox.ReadOnly = true;
            this.contusionEcchymosisLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.contusionEcchymosisLengthTextBox.TabIndex = 9;
            // 
            // signsofInflammationLocationTextBox
            // 
            this.signsofInflammationLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "SignsofInflammationLocation", true));
            this.signsofInflammationLocationTextBox.Location = new System.Drawing.Point(76, 181);
            this.signsofInflammationLocationTextBox.Name = "signsofInflammationLocationTextBox";
            this.signsofInflammationLocationTextBox.ReadOnly = true;
            this.signsofInflammationLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.signsofInflammationLocationTextBox.TabIndex = 7;
            // 
            // contusionEcchymosisComboBox
            // 
            this.contusionEcchymosisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "ContusionEcchymosis", true));
            this.contusionEcchymosisComboBox.Enabled = false;
            this.contusionEcchymosisComboBox.FormattingEnabled = true;
            this.contusionEcchymosisComboBox.Items.AddRange(new object[] {
            "Yes",
            "N/A"});
            this.contusionEcchymosisComboBox.Location = new System.Drawing.Point(156, 205);
            this.contusionEcchymosisComboBox.Name = "contusionEcchymosisComboBox";
            this.contusionEcchymosisComboBox.Size = new System.Drawing.Size(121, 21);
            this.contusionEcchymosisComboBox.TabIndex = 8;
            // 
            // signsofInflammationComboBox
            // 
            this.signsofInflammationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "SignsofInflammation", true));
            this.signsofInflammationComboBox.Enabled = false;
            this.signsofInflammationComboBox.FormattingEnabled = true;
            this.signsofInflammationComboBox.Items.AddRange(new object[] {
            "Redness",
            "Tenderness/pain",
            "Warmth",
            "Swelling"});
            this.signsofInflammationComboBox.Location = new System.Drawing.Point(156, 156);
            this.signsofInflammationComboBox.Name = "signsofInflammationComboBox";
            this.signsofInflammationComboBox.Size = new System.Drawing.Size(121, 21);
            this.signsofInflammationComboBox.TabIndex = 6;
            // 
            // skinIsComboBox
            // 
            this.skinIsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "SkinIs", true));
            this.skinIsComboBox.Enabled = false;
            this.skinIsComboBox.FormattingEnabled = true;
            this.skinIsComboBox.Items.AddRange(new object[] {
            "Intact",
            "No, see below",
            "No, describe"});
            this.skinIsComboBox.Location = new System.Drawing.Point(76, 131);
            this.skinIsComboBox.Name = "skinIsComboBox";
            this.skinIsComboBox.Size = new System.Drawing.Size(121, 21);
            this.skinIsComboBox.TabIndex = 4;
            // 
            // skinColorComboBox
            // 
            this.skinColorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skinIntegrityBindingSource, "SkinColor", true));
            this.skinColorComboBox.Enabled = false;
            this.skinColorComboBox.FormattingEnabled = true;
            this.skinColorComboBox.Items.AddRange(new object[] {
            "WNL",
            "Pale",
            "Jaundice",
            "Dusky",
            "Cyanotic"});
            this.skinColorComboBox.Location = new System.Drawing.Point(76, 106);
            this.skinColorComboBox.Name = "skinColorComboBox";
            this.skinColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.skinColorComboBox.TabIndex = 3;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(10, 259);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(59, 13);
            this.label162.TabIndex = 122;
            this.label162.Text = "Location(s)";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(10, 234);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(63, 13);
            this.label161.TabIndex = 120;
            this.label161.Text = "Length (cm)";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.Location = new System.Drawing.Point(10, 209);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(126, 13);
            this.label160.TabIndex = 118;
            this.label160.Text = "Contusion(s)/Ecchymosis";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(10, 184);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(59, 13);
            this.label159.TabIndex = 116;
            this.label159.Text = "Location(s)";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.Location = new System.Drawing.Point(10, 159);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(144, 13);
            this.label158.TabIndex = 114;
            this.label158.Text = "S/S of inflammation/infection";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label157.Location = new System.Drawing.Point(198, 135);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(49, 13);
            this.label157.TabIndex = 113;
            this.label157.Text = "Describe";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.Location = new System.Drawing.Point(10, 134);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(38, 13);
            this.label156.TabIndex = 111;
            this.label156.Text = "Skin is";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(10, 109);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(55, 13);
            this.label154.TabIndex = 109;
            this.label154.Text = "Skin Color";
            // 
            // tabpageGastro
            // 
            this.tabpageGastro.AutoScroll = true;
            this.tabpageGastro.Controls.Add(this.label36);
            this.tabpageGastro.Controls.Add(this.dateTimeTextBoxGastro);
            this.tabpageGastro.Controls.Add(this.patientIDTextBoxGastro);
            this.tabpageGastro.Controls.Add(this.tubeFeedingAmountTextBox);
            this.tabpageGastro.Controls.Add(this.tubeFeedingTypeTextBox);
            this.tabpageGastro.Controls.Add(this.tubesPHAspirateTextBox);
            this.tabpageGastro.Controls.Add(this.lastBowelMovementOtherTextBox);
            this.tabpageGastro.Controls.Add(this.bowelMovementsOtherTextBox);
            this.tabpageGastro.Controls.Add(this.abdominalGirthTextBox);
            this.tabpageGastro.Controls.Add(this.btnNewGastro);
            this.tabpageGastro.Controls.Add(this.bindingNavigator2);
            this.tabpageGastro.Controls.Add(this.btnSaveGastro);
            this.tabpageGastro.Controls.Add(dateTimeLabel4);
            this.tabpageGastro.Controls.Add(patientIDLabel4);
            this.tabpageGastro.Controls.Add(this.stomaStatusComboBox);
            this.tabpageGastro.Controls.Add(this.stomaComboBox);
            this.tabpageGastro.Controls.Add(this.tubeFeedingComboBox);
            this.tabpageGastro.Controls.Add(this.insertionSiteComboBox1);
            this.tabpageGastro.Controls.Add(this.tubesComboBox);
            this.tabpageGastro.Controls.Add(this.bowelSoundsComboBox);
            this.tabpageGastro.Controls.Add(this.nutritionalIntakeComboBox);
            this.tabpageGastro.Controls.Add(this.continentComboBox);
            this.tabpageGastro.Controls.Add(this.lastBowelMovementComboBox);
            this.tabpageGastro.Controls.Add(this.bowelMovementsComboBox);
            this.tabpageGastro.Controls.Add(this.abdomenComboBox);
            this.tabpageGastro.Controls.Add(this.tongueComboBox);
            this.tabpageGastro.Controls.Add(this.oralMucosaComboBox);
            this.tabpageGastro.Controls.Add(this.label124);
            this.tabpageGastro.Controls.Add(this.label123);
            this.tabpageGastro.Controls.Add(this.label122);
            this.tabpageGastro.Controls.Add(this.label121);
            this.tabpageGastro.Controls.Add(this.label120);
            this.tabpageGastro.Controls.Add(this.label119);
            this.tabpageGastro.Controls.Add(this.label106);
            this.tabpageGastro.Controls.Add(this.label118);
            this.tabpageGastro.Controls.Add(this.label105);
            this.tabpageGastro.Controls.Add(this.label117);
            this.tabpageGastro.Controls.Add(this.label115);
            this.tabpageGastro.Controls.Add(this.label113);
            this.tabpageGastro.Controls.Add(this.label112);
            this.tabpageGastro.Controls.Add(this.label111);
            this.tabpageGastro.Controls.Add(this.label109);
            this.tabpageGastro.Controls.Add(this.label108);
            this.tabpageGastro.Controls.Add(this.label107);
            this.tabpageGastro.Controls.Add(this.label104);
            this.tabpageGastro.Controls.Add(this.label103);
            this.tabpageGastro.Controls.Add(this.label102);
            this.tabpageGastro.Controls.Add(this.label101);
            this.tabpageGastro.Controls.Add(this.label100);
            this.tabpageGastro.Location = new System.Drawing.Point(4, 22);
            this.tabpageGastro.Name = "tabpageGastro";
            this.tabpageGastro.Size = new System.Drawing.Size(645, 528);
            this.tabpageGastro.TabIndex = 4;
            this.tabpageGastro.Text = "Gastrointestinal";
            this.tabpageGastro.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(345, 76);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(154, 13);
            this.label36.TabIndex = 211;
            this.label36.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // dateTimeTextBoxGastro
            // 
            this.dateTimeTextBoxGastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "DateTime", true));
            this.dateTimeTextBoxGastro.Location = new System.Drawing.Point(390, 55);
            this.dateTimeTextBoxGastro.Name = "dateTimeTextBoxGastro";
            this.dateTimeTextBoxGastro.ReadOnly = true;
            this.dateTimeTextBoxGastro.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTextBoxGastro.TabIndex = 2;
            this.dateTimeTextBoxGastro.Tag = "Date + Time";
            // 
            // patientIDTextBoxGastro
            // 
            this.patientIDTextBoxGastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "PatientID", true));
            this.patientIDTextBoxGastro.Location = new System.Drawing.Point(214, 55);
            this.patientIDTextBoxGastro.Name = "patientIDTextBoxGastro";
            this.patientIDTextBoxGastro.ReadOnly = true;
            this.patientIDTextBoxGastro.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBoxGastro.TabIndex = 1;
            this.patientIDTextBoxGastro.Tag = "Patient ID";
            // 
            // tubeFeedingAmountTextBox
            // 
            this.tubeFeedingAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "TubeFeedingAmount", true));
            this.tubeFeedingAmountTextBox.Location = new System.Drawing.Point(181, 397);
            this.tubeFeedingAmountTextBox.Name = "tubeFeedingAmountTextBox";
            this.tubeFeedingAmountTextBox.ReadOnly = true;
            this.tubeFeedingAmountTextBox.Size = new System.Drawing.Size(48, 20);
            this.tubeFeedingAmountTextBox.TabIndex = 20;
            // 
            // tubeFeedingTypeTextBox
            // 
            this.tubeFeedingTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "TubeFeedingType", true));
            this.tubeFeedingTypeTextBox.Location = new System.Drawing.Point(73, 397);
            this.tubeFeedingTypeTextBox.Name = "tubeFeedingTypeTextBox";
            this.tubeFeedingTypeTextBox.ReadOnly = true;
            this.tubeFeedingTypeTextBox.Size = new System.Drawing.Size(50, 20);
            this.tubeFeedingTypeTextBox.TabIndex = 19;
            // 
            // tubesPHAspirateTextBox
            // 
            this.tubesPHAspirateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "TubesPHAspirate", true));
            this.tubesPHAspirateTextBox.Location = new System.Drawing.Point(331, 360);
            this.tubesPHAspirateTextBox.Name = "tubesPHAspirateTextBox";
            this.tubesPHAspirateTextBox.ReadOnly = true;
            this.tubesPHAspirateTextBox.Size = new System.Drawing.Size(48, 20);
            this.tubesPHAspirateTextBox.TabIndex = 18;
            // 
            // lastBowelMovementOtherTextBox
            // 
            this.lastBowelMovementOtherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "LastBowelMovementOther", true));
            this.lastBowelMovementOtherTextBox.Location = new System.Drawing.Point(351, 212);
            this.lastBowelMovementOtherTextBox.Name = "lastBowelMovementOtherTextBox";
            this.lastBowelMovementOtherTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastBowelMovementOtherTextBox.TabIndex = 10;
            // 
            // bowelMovementsOtherTextBox
            // 
            this.bowelMovementsOtherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "BowelMovementsOther", true));
            this.bowelMovementsOtherTextBox.Location = new System.Drawing.Point(351, 181);
            this.bowelMovementsOtherTextBox.Name = "bowelMovementsOtherTextBox";
            this.bowelMovementsOtherTextBox.Size = new System.Drawing.Size(100, 20);
            this.bowelMovementsOtherTextBox.TabIndex = 8;
            // 
            // abdominalGirthTextBox
            // 
            this.abdominalGirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "AbdominalGirth", true));
            this.abdominalGirthTextBox.Location = new System.Drawing.Point(382, 147);
            this.abdominalGirthTextBox.Name = "abdominalGirthTextBox";
            this.abdominalGirthTextBox.ReadOnly = true;
            this.abdominalGirthTextBox.Size = new System.Drawing.Size(58, 20);
            this.abdominalGirthTextBox.TabIndex = 6;
            // 
            // btnNewGastro
            // 
            this.btnNewGastro.Location = new System.Drawing.Point(285, 13);
            this.btnNewGastro.Name = "btnNewGastro";
            this.btnNewGastro.Size = new System.Drawing.Size(75, 23);
            this.btnNewGastro.TabIndex = 0;
            this.btnNewGastro.Text = "New";
            this.btnNewGastro.UseVisualStyleBackColor = true;
            this.btnNewGastro.Click += new System.EventHandler(this.btnNewGastro_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBackGastro,
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.toolStripLabel3,
            this.tsTxtPtIDGastro,
            this.tsBtnSearchGastro});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 503);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigator2.Size = new System.Drawing.Size(645, 25);
            this.bindingNavigator2.TabIndex = 187;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem4.Text = "of {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Total number of items";
            // 
            // tsBtnBackGastro
            // 
            this.tsBtnBackGastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBackGastro.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBackGastro.Image")));
            this.tsBtnBackGastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackGastro.Name = "tsBtnBackGastro";
            this.tsBtnBackGastro.Size = new System.Drawing.Size(36, 22);
            this.tsBtnBackGastro.Text = "Back";
            this.tsBtnBackGastro.Click += new System.EventHandler(this.tsBtnBackGastro_Click);
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "Move previous";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Position";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "Move last";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "Pt ID:";
            // 
            // tsTxtPtIDGastro
            // 
            this.tsTxtPtIDGastro.Name = "tsTxtPtIDGastro";
            this.tsTxtPtIDGastro.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnSearchGastro
            // 
            this.tsBtnSearchGastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearchGastro.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearchGastro.Image")));
            this.tsBtnSearchGastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearchGastro.Name = "tsBtnSearchGastro";
            this.tsBtnSearchGastro.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSearchGastro.Text = "Search";
            this.tsBtnSearchGastro.Click += new System.EventHandler(this.tsBtnSearchGastro_Click);
            // 
            // btnSaveGastro
            // 
            this.btnSaveGastro.Location = new System.Drawing.Point(285, 466);
            this.btnSaveGastro.Name = "btnSaveGastro";
            this.btnSaveGastro.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGastro.TabIndex = 24;
            this.btnSaveGastro.Text = "Save";
            this.btnSaveGastro.UseVisualStyleBackColor = true;
            this.btnSaveGastro.Click += new System.EventHandler(this.btnSaveGastro_Click);
            // 
            // stomaStatusComboBox
            // 
            this.stomaStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "StomaStatus", true));
            this.stomaStatusComboBox.Enabled = false;
            this.stomaStatusComboBox.FormattingEnabled = true;
            this.stomaStatusComboBox.Items.AddRange(new object[] {
            "Pink, viable",
            "Red",
            "Deep red",
            "Dusky",
            "Dark",
            "Retracted below skin",
            "S/S of infection"});
            this.stomaStatusComboBox.Location = new System.Drawing.Point(315, 424);
            this.stomaStatusComboBox.Name = "stomaStatusComboBox";
            this.stomaStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.stomaStatusComboBox.TabIndex = 23;
            // 
            // stomaComboBox
            // 
            this.stomaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "Stoma", true));
            this.stomaComboBox.Enabled = false;
            this.stomaComboBox.FormattingEnabled = true;
            this.stomaComboBox.Items.AddRange(new object[] {
            "N/A",
            "Colostomy",
            "Ileaostomy"});
            this.stomaComboBox.Location = new System.Drawing.Point(73, 423);
            this.stomaComboBox.Name = "stomaComboBox";
            this.stomaComboBox.Size = new System.Drawing.Size(121, 21);
            this.stomaComboBox.TabIndex = 22;
            // 
            // tubeFeedingComboBox
            // 
            this.tubeFeedingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "TubeFeeding", true));
            this.tubeFeedingComboBox.Enabled = false;
            this.tubeFeedingComboBox.FormattingEnabled = true;
            this.tubeFeedingComboBox.Items.AddRange(new object[] {
            "Gravity",
            "Pump",
            "Intermittent",
            "Continuous"});
            this.tubeFeedingComboBox.Location = new System.Drawing.Point(315, 398);
            this.tubeFeedingComboBox.Name = "tubeFeedingComboBox";
            this.tubeFeedingComboBox.Size = new System.Drawing.Size(121, 21);
            this.tubeFeedingComboBox.TabIndex = 21;
            // 
            // insertionSiteComboBox1
            // 
            this.insertionSiteComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "InsertionSite", true));
            this.insertionSiteComboBox1.Enabled = false;
            this.insertionSiteComboBox1.FormattingEnabled = true;
            this.insertionSiteComboBox1.Items.AddRange(new object[] {
            "WNL",
            "Pressure areas",
            "Redness",
            "Purulent drainage",
            "Tenderness",
            "Warmth"});
            this.insertionSiteComboBox1.Location = new System.Drawing.Point(139, 360);
            this.insertionSiteComboBox1.Name = "insertionSiteComboBox1";
            this.insertionSiteComboBox1.Size = new System.Drawing.Size(121, 21);
            this.insertionSiteComboBox1.TabIndex = 17;
            // 
            // tubesComboBox
            // 
            this.tubesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "Tubes", true));
            this.tubesComboBox.Enabled = false;
            this.tubesComboBox.FormattingEnabled = true;
            this.tubesComboBox.Items.AddRange(new object[] {
            "None",
            "Salem sump",
            "Nasoduodenal feeding tube",
            "PEG tube",
            "Jejunostomy(J) tube"});
            this.tubesComboBox.Location = new System.Drawing.Point(139, 330);
            this.tubesComboBox.Name = "tubesComboBox";
            this.tubesComboBox.Size = new System.Drawing.Size(121, 21);
            this.tubesComboBox.TabIndex = 16;
            // 
            // bowelSoundsComboBox
            // 
            this.bowelSoundsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "BowelSounds", true));
            this.bowelSoundsComboBox.Enabled = false;
            this.bowelSoundsComboBox.FormattingEnabled = true;
            this.bowelSoundsComboBox.Items.AddRange(new object[] {
            "Active, WNL",
            "Hyperactive",
            "Hypoactive",
            "Absent(listen 5 full minutes)"});
            this.bowelSoundsComboBox.Location = new System.Drawing.Point(139, 300);
            this.bowelSoundsComboBox.Name = "bowelSoundsComboBox";
            this.bowelSoundsComboBox.Size = new System.Drawing.Size(121, 21);
            this.bowelSoundsComboBox.TabIndex = 15;
            // 
            // nutritionalIntakeComboBox
            // 
            this.nutritionalIntakeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "NutritionalIntake", true));
            this.nutritionalIntakeComboBox.Enabled = false;
            this.nutritionalIntakeComboBox.FormattingEnabled = true;
            this.nutritionalIntakeComboBox.Items.AddRange(new object[] {
            "Adequate",
            "Inadequate"});
            this.nutritionalIntakeComboBox.Location = new System.Drawing.Point(139, 270);
            this.nutritionalIntakeComboBox.Name = "nutritionalIntakeComboBox";
            this.nutritionalIntakeComboBox.Size = new System.Drawing.Size(121, 21);
            this.nutritionalIntakeComboBox.TabIndex = 14;
            // 
            // continentComboBox
            // 
            this.continentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "Continent", true));
            this.continentComboBox.Enabled = false;
            this.continentComboBox.FormattingEnabled = true;
            this.continentComboBox.Items.AddRange(new object[] {
            "Yes",
            "Rarely Incontinent",
            "Regularly incontinent"});
            this.continentComboBox.Location = new System.Drawing.Point(138, 242);
            this.continentComboBox.Name = "continentComboBox";
            this.continentComboBox.Size = new System.Drawing.Size(121, 21);
            this.continentComboBox.TabIndex = 11;
            // 
            // lastBowelMovementComboBox
            // 
            this.lastBowelMovementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "LastBowelMovement", true));
            this.lastBowelMovementComboBox.Enabled = false;
            this.lastBowelMovementComboBox.FormattingEnabled = true;
            this.lastBowelMovementComboBox.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "Other"});
            this.lastBowelMovementComboBox.Location = new System.Drawing.Point(138, 212);
            this.lastBowelMovementComboBox.Name = "lastBowelMovementComboBox";
            this.lastBowelMovementComboBox.Size = new System.Drawing.Size(121, 21);
            this.lastBowelMovementComboBox.TabIndex = 9;
            // 
            // bowelMovementsComboBox
            // 
            this.bowelMovementsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "BowelMovements", true));
            this.bowelMovementsComboBox.Enabled = false;
            this.bowelMovementsComboBox.FormattingEnabled = true;
            this.bowelMovementsComboBox.Items.AddRange(new object[] {
            "WNL",
            "Constipation",
            "Diarrhea",
            "Bowel program required",
            "Other"});
            this.bowelMovementsComboBox.Location = new System.Drawing.Point(138, 182);
            this.bowelMovementsComboBox.Name = "bowelMovementsComboBox";
            this.bowelMovementsComboBox.Size = new System.Drawing.Size(121, 21);
            this.bowelMovementsComboBox.TabIndex = 7;
            // 
            // abdomenComboBox
            // 
            this.abdomenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "Abdomen", true));
            this.abdomenComboBox.Enabled = false;
            this.abdomenComboBox.FormattingEnabled = true;
            this.abdomenComboBox.Items.AddRange(new object[] {
            "WNL",
            "Distended",
            "Taut",
            "Ascites",
            "Abdominal incision"});
            this.abdomenComboBox.Location = new System.Drawing.Point(137, 147);
            this.abdomenComboBox.Name = "abdomenComboBox";
            this.abdomenComboBox.Size = new System.Drawing.Size(121, 21);
            this.abdomenComboBox.TabIndex = 5;
            // 
            // tongueComboBox
            // 
            this.tongueComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "Tongue", true));
            this.tongueComboBox.Enabled = false;
            this.tongueComboBox.FormattingEnabled = true;
            this.tongueComboBox.Items.AddRange(new object[] {
            "WNL",
            "Pink",
            "White patches"});
            this.tongueComboBox.Location = new System.Drawing.Point(137, 114);
            this.tongueComboBox.Name = "tongueComboBox";
            this.tongueComboBox.Size = new System.Drawing.Size(121, 21);
            this.tongueComboBox.TabIndex = 4;
            // 
            // oralMucosaComboBox
            // 
            this.oralMucosaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastrointestinalBindingSource, "OralMucosa", true));
            this.oralMucosaComboBox.Enabled = false;
            this.oralMucosaComboBox.FormattingEnabled = true;
            this.oralMucosaComboBox.Items.AddRange(new object[] {
            "Intact",
            "Moist",
            "Dry",
            "Pink",
            "Pale"});
            this.oralMucosaComboBox.Location = new System.Drawing.Point(137, 84);
            this.oralMucosaComboBox.Name = "oralMucosaComboBox";
            this.oralMucosaComboBox.Size = new System.Drawing.Size(121, 21);
            this.oralMucosaComboBox.TabIndex = 3;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.Location = new System.Drawing.Point(240, 426);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(68, 13);
            this.label124.TabIndex = 153;
            this.label124.Text = "Stoma status";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(31, 427);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(37, 13);
            this.label123.TabIndex = 151;
            this.label123.Text = "Stoma";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label122.Location = new System.Drawing.Point(287, 401);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(21, 13);
            this.label122.TabIndex = 150;
            this.label122.Text = "via";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(232, 401);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(46, 13);
            this.label121.TabIndex = 149;
            this.label121.Text = "mls over";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.Location = new System.Drawing.Point(132, 401);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(43, 13);
            this.label120.TabIndex = 148;
            this.label120.Text = "Amount";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.Location = new System.Drawing.Point(31, 401);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(31, 13);
            this.label119.TabIndex = 146;
            this.label119.Text = "Type";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(19, 380);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(82, 13);
            this.label106.TabIndex = 143;
            this.label106.Text = "Tube feeding";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.Location = new System.Drawing.Point(264, 364);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(61, 13);
            this.label118.TabIndex = 142;
            this.label118.Text = "pH aspirate";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.Location = new System.Drawing.Point(26, 363);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(66, 13);
            this.label105.TabIndex = 139;
            this.label105.Text = "Insertion site";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(26, 333);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(40, 13);
            this.label117.TabIndex = 137;
            this.label117.Text = "Tubes:";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.Location = new System.Drawing.Point(26, 303);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(75, 13);
            this.label115.TabIndex = 134;
            this.label115.Text = "Bowel Sounds";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(263, 216);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(86, 13);
            this.label113.TabIndex = 132;
            this.label113.Text = "If other, describe";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(263, 185);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(86, 13);
            this.label112.TabIndex = 131;
            this.label112.Text = "If other, describe";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(26, 273);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(86, 13);
            this.label111.TabIndex = 129;
            this.label111.Text = "Nutritional intake";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.Location = new System.Drawing.Point(25, 245);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(52, 13);
            this.label109.TabIndex = 125;
            this.label109.Text = "Continent";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(25, 215);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(112, 13);
            this.label108.TabIndex = 123;
            this.label108.Text = "Last Bowel Movement";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(25, 185);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(93, 13);
            this.label107.TabIndex = 121;
            this.label107.Text = "Bowel movements";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.Location = new System.Drawing.Point(446, 151);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(21, 13);
            this.label104.TabIndex = 117;
            this.label104.Text = "cm";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(269, 151);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(108, 13);
            this.label103.TabIndex = 116;
            this.label103.Text = "Abdominal girth(PRN)";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(24, 151);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(52, 13);
            this.label102.TabIndex = 113;
            this.label102.Text = "Abdomen";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(24, 116);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(44, 13);
            this.label101.TabIndex = 111;
            this.label101.Text = "Tongue";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(24, 86);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(67, 13);
            this.label100.TabIndex = 109;
            this.label100.Text = "Oral Mucosa";
            // 
            // tabpageUrinary
            // 
            this.tabpageUrinary.AutoScroll = true;
            this.tabpageUrinary.Controls.Add(this.label35);
            this.tabpageUrinary.Controls.Add(this.bindingNavigator3);
            this.tabpageUrinary.Controls.Add(this.btnSaveGenit);
            this.tabpageUrinary.Controls.Add(this.btnNewGenit);
            this.tabpageUrinary.Controls.Add(this.dateTimeTextBoxGenit);
            this.tabpageUrinary.Controls.Add(this.patientIDTextBoxGenit);
            this.tabpageUrinary.Controls.Add(this.ifGenitaliaAbnormalitiesTextBox);
            this.tabpageUrinary.Controls.Add(dateTimeLabel3);
            this.tabpageUrinary.Controls.Add(patientIDLabel3);
            this.tabpageUrinary.Controls.Add(this.insertionSiteComboBox2);
            this.tabpageUrinary.Controls.Add(this.urinaryCatheterComboBox);
            this.tabpageUrinary.Controls.Add(this.urinaryStentsComboBox);
            this.tabpageUrinary.Controls.Add(this.stomaStatusComboBox1);
            this.tabpageUrinary.Controls.Add(this.urostomyComboBox);
            this.tabpageUrinary.Controls.Add(this.urineCharComboBox);
            this.tabpageUrinary.Controls.Add(this.urineColorComboBox);
            this.tabpageUrinary.Controls.Add(this.urineAmountComboBox);
            this.tabpageUrinary.Controls.Add(this.continentGenComboBox);
            this.tabpageUrinary.Controls.Add(this.urinationAssessmentComboBox);
            this.tabpageUrinary.Controls.Add(this.genitaliaComboBox);
            this.tabpageUrinary.Controls.Add(this.label93);
            this.tabpageUrinary.Controls.Add(this.label34);
            this.tabpageUrinary.Controls.Add(this.label33);
            this.tabpageUrinary.Controls.Add(this.label32);
            this.tabpageUrinary.Controls.Add(this.label31);
            this.tabpageUrinary.Controls.Add(this.label30);
            this.tabpageUrinary.Controls.Add(this.label29);
            this.tabpageUrinary.Controls.Add(this.label28);
            this.tabpageUrinary.Controls.Add(this.label27);
            this.tabpageUrinary.Controls.Add(this.label26);
            this.tabpageUrinary.Controls.Add(this.label25);
            this.tabpageUrinary.Controls.Add(this.label24);
            this.tabpageUrinary.Location = new System.Drawing.Point(4, 22);
            this.tabpageUrinary.Name = "tabpageUrinary";
            this.tabpageUrinary.Size = new System.Drawing.Size(645, 528);
            this.tabpageUrinary.TabIndex = 3;
            this.tabpageUrinary.Text = "Genitourinary";
            this.tabpageUrinary.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(344, 93);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 13);
            this.label35.TabIndex = 211;
            this.label35.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem5;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBack,
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.toolStripLabel4,
            this.tsTxtPtIDGenit,
            this.tsBtnSearchGenit});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 503);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem5;
            this.bindingNavigator3.Size = new System.Drawing.Size(645, 25);
            this.bindingNavigator3.TabIndex = 190;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem5.Text = "of {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "Total number of items";
            // 
            // tsBtnBack
            // 
            this.tsBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBack.Image")));
            this.tsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBack.Name = "tsBtnBack";
            this.tsBtnBack.Size = new System.Drawing.Size(36, 22);
            this.tsBtnBack.Text = "Back";
            this.tsBtnBack.Click += new System.EventHandler(this.tsBtnBack_Click);
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "Move previous";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "Position";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "Move last";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "Pt ID:";
            // 
            // tsTxtPtIDGenit
            // 
            this.tsTxtPtIDGenit.Name = "tsTxtPtIDGenit";
            this.tsTxtPtIDGenit.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnSearchGenit
            // 
            this.tsBtnSearchGenit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearchGenit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearchGenit.Image")));
            this.tsBtnSearchGenit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearchGenit.Name = "tsBtnSearchGenit";
            this.tsBtnSearchGenit.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSearchGenit.Text = "Search";
            this.tsBtnSearchGenit.Click += new System.EventHandler(this.tsBtnSearch_Click);
            // 
            // btnSaveGenit
            // 
            this.btnSaveGenit.Location = new System.Drawing.Point(285, 425);
            this.btnSaveGenit.Name = "btnSaveGenit";
            this.btnSaveGenit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGenit.TabIndex = 189;
            this.btnSaveGenit.Text = "Save";
            this.btnSaveGenit.UseVisualStyleBackColor = true;
            this.btnSaveGenit.Click += new System.EventHandler(this.btnSaveGenit_Click);
            // 
            // btnNewGenit
            // 
            this.btnNewGenit.Location = new System.Drawing.Point(285, 21);
            this.btnNewGenit.Name = "btnNewGenit";
            this.btnNewGenit.Size = new System.Drawing.Size(75, 23);
            this.btnNewGenit.TabIndex = 188;
            this.btnNewGenit.Text = "New";
            this.btnNewGenit.UseVisualStyleBackColor = true;
            this.btnNewGenit.Click += new System.EventHandler(this.btnNewGenit_Click);
            // 
            // dateTimeTextBoxGenit
            // 
            this.dateTimeTextBoxGenit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "DateTime", true));
            this.dateTimeTextBoxGenit.Location = new System.Drawing.Point(398, 71);
            this.dateTimeTextBoxGenit.Name = "dateTimeTextBoxGenit";
            this.dateTimeTextBoxGenit.ReadOnly = true;
            this.dateTimeTextBoxGenit.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTextBoxGenit.TabIndex = 187;
            this.dateTimeTextBoxGenit.Tag = "Date + Time";
            // 
            // patientIDTextBoxGenit
            // 
            this.patientIDTextBoxGenit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "PatientID", true));
            this.patientIDTextBoxGenit.Location = new System.Drawing.Point(210, 71);
            this.patientIDTextBoxGenit.Name = "patientIDTextBoxGenit";
            this.patientIDTextBoxGenit.ReadOnly = true;
            this.patientIDTextBoxGenit.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBoxGenit.TabIndex = 185;
            this.patientIDTextBoxGenit.Tag = "Patient ID";
            // 
            // ifGenitaliaAbnormalitiesTextBox
            // 
            this.ifGenitaliaAbnormalitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "IfGenitaliaAbnormalities", true));
            this.ifGenitaliaAbnormalitiesTextBox.Location = new System.Drawing.Point(369, 108);
            this.ifGenitaliaAbnormalitiesTextBox.Name = "ifGenitaliaAbnormalitiesTextBox";
            this.ifGenitaliaAbnormalitiesTextBox.ReadOnly = true;
            this.ifGenitaliaAbnormalitiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifGenitaliaAbnormalitiesTextBox.TabIndex = 113;
            // 
            // insertionSiteComboBox2
            // 
            this.insertionSiteComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "InsertionSite", true));
            this.insertionSiteComboBox2.Enabled = false;
            this.insertionSiteComboBox2.FormattingEnabled = true;
            this.insertionSiteComboBox2.Items.AddRange(new object[] {
            "WNL",
            "S/S of infection"});
            this.insertionSiteComboBox2.Location = new System.Drawing.Point(131, 398);
            this.insertionSiteComboBox2.Name = "insertionSiteComboBox2";
            this.insertionSiteComboBox2.Size = new System.Drawing.Size(121, 21);
            this.insertionSiteComboBox2.TabIndex = 123;
            // 
            // urinaryCatheterComboBox
            // 
            this.urinaryCatheterComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "UrinaryCatheter", true));
            this.urinaryCatheterComboBox.Enabled = false;
            this.urinaryCatheterComboBox.FormattingEnabled = true;
            this.urinaryCatheterComboBox.Items.AddRange(new object[] {
            "N/A",
            "Foley, short term",
            "Foley, long term at home",
            "Suprapubic catheter"});
            this.urinaryCatheterComboBox.Location = new System.Drawing.Point(131, 369);
            this.urinaryCatheterComboBox.Name = "urinaryCatheterComboBox";
            this.urinaryCatheterComboBox.Size = new System.Drawing.Size(121, 21);
            this.urinaryCatheterComboBox.TabIndex = 122;
            // 
            // urinaryStentsComboBox
            // 
            this.urinaryStentsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "UrinaryStents", true));
            this.urinaryStentsComboBox.Enabled = false;
            this.urinaryStentsComboBox.FormattingEnabled = true;
            this.urinaryStentsComboBox.Items.AddRange(new object[] {
            "N/A",
            "R ureter",
            "L ureter"});
            this.urinaryStentsComboBox.Location = new System.Drawing.Point(131, 340);
            this.urinaryStentsComboBox.Name = "urinaryStentsComboBox";
            this.urinaryStentsComboBox.Size = new System.Drawing.Size(121, 21);
            this.urinaryStentsComboBox.TabIndex = 121;
            // 
            // stomaStatusComboBox1
            // 
            this.stomaStatusComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "StomaStatus", true));
            this.stomaStatusComboBox1.Enabled = false;
            this.stomaStatusComboBox1.FormattingEnabled = true;
            this.stomaStatusComboBox1.Items.AddRange(new object[] {
            "Pink, viable",
            "Red",
            "Deep red",
            "Dusky",
            "Dark",
            "Retracted below skin",
            "S/S of infection"});
            this.stomaStatusComboBox1.Location = new System.Drawing.Point(131, 311);
            this.stomaStatusComboBox1.Name = "stomaStatusComboBox1";
            this.stomaStatusComboBox1.Size = new System.Drawing.Size(121, 21);
            this.stomaStatusComboBox1.TabIndex = 120;
            // 
            // urostomyComboBox
            // 
            this.urostomyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "Urostomy", true));
            this.urostomyComboBox.Enabled = false;
            this.urostomyComboBox.FormattingEnabled = true;
            this.urostomyComboBox.Items.AddRange(new object[] {
            "N/A",
            "Urosotomy/ileal conduit",
            "Continence maintaining nipple valve ostomy"});
            this.urostomyComboBox.Location = new System.Drawing.Point(131, 282);
            this.urostomyComboBox.Name = "urostomyComboBox";
            this.urostomyComboBox.Size = new System.Drawing.Size(121, 21);
            this.urostomyComboBox.TabIndex = 119;
            // 
            // urineCharComboBox
            // 
            this.urineCharComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "UrineChar", true));
            this.urineCharComboBox.Enabled = false;
            this.urineCharComboBox.FormattingEnabled = true;
            this.urineCharComboBox.Items.AddRange(new object[] {
            "Clear,WNL",
            "Cloudy",
            "Sediment",
            "Abnormal odor"});
            this.urineCharComboBox.Location = new System.Drawing.Point(131, 253);
            this.urineCharComboBox.Name = "urineCharComboBox";
            this.urineCharComboBox.Size = new System.Drawing.Size(121, 21);
            this.urineCharComboBox.TabIndex = 118;
            // 
            // urineColorComboBox
            // 
            this.urineColorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "UrineColor", true));
            this.urineColorComboBox.Enabled = false;
            this.urineColorComboBox.FormattingEnabled = true;
            this.urineColorComboBox.Items.AddRange(new object[] {
            "Yellow,WNL",
            "Amber",
            "Orange",
            "Dark Amber",
            "Pink",
            "Red tinged",
            "Grossly bloody"});
            this.urineColorComboBox.Location = new System.Drawing.Point(131, 224);
            this.urineColorComboBox.Name = "urineColorComboBox";
            this.urineColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.urineColorComboBox.TabIndex = 117;
            // 
            // urineAmountComboBox
            // 
            this.urineAmountComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "UrineAmount", true));
            this.urineAmountComboBox.Enabled = false;
            this.urineAmountComboBox.FormattingEnabled = true;
            this.urineAmountComboBox.Items.AddRange(new object[] {
            "WNL (>30ml/hr)",
            "<30 ml/hr",
            "Output > intake"});
            this.urineAmountComboBox.Location = new System.Drawing.Point(131, 195);
            this.urineAmountComboBox.Name = "urineAmountComboBox";
            this.urineAmountComboBox.Size = new System.Drawing.Size(121, 21);
            this.urineAmountComboBox.TabIndex = 116;
            // 
            // continentGenComboBox
            // 
            this.continentGenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "ContinentGen", true));
            this.continentGenComboBox.Enabled = false;
            this.continentGenComboBox.FormattingEnabled = true;
            this.continentGenComboBox.Items.AddRange(new object[] {
            "Yes",
            "Stress incontince w/ coughing, etc.",
            "Rarely incontinent",
            "Regularly incontinent"});
            this.continentGenComboBox.Location = new System.Drawing.Point(131, 166);
            this.continentGenComboBox.Name = "continentGenComboBox";
            this.continentGenComboBox.Size = new System.Drawing.Size(121, 21);
            this.continentGenComboBox.TabIndex = 115;
            // 
            // urinationAssessmentComboBox
            // 
            this.urinationAssessmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "UrinationAssessment", true));
            this.urinationAssessmentComboBox.Enabled = false;
            this.urinationAssessmentComboBox.FormattingEnabled = true;
            this.urinationAssessmentComboBox.Items.AddRange(new object[] {
            "WNL",
            "Burning",
            "Frequency",
            "Urgency",
            "Bladder distention",
            "Pelvic pain/discomfort",
            "Lower back/flank pain/discomfort"});
            this.urinationAssessmentComboBox.Location = new System.Drawing.Point(131, 137);
            this.urinationAssessmentComboBox.Name = "urinationAssessmentComboBox";
            this.urinationAssessmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.urinationAssessmentComboBox.TabIndex = 114;
            // 
            // genitaliaComboBox
            // 
            this.genitaliaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genitourinaryBindingSource, "Genitalia", true));
            this.genitaliaComboBox.Enabled = false;
            this.genitaliaComboBox.FormattingEnabled = true;
            this.genitaliaComboBox.Items.AddRange(new object[] {
            "WNL",
            "Abnormalities"});
            this.genitaliaComboBox.Location = new System.Drawing.Point(131, 108);
            this.genitaliaComboBox.Name = "genitaliaComboBox";
            this.genitaliaComboBox.Size = new System.Drawing.Size(121, 21);
            this.genitaliaComboBox.TabIndex = 112;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(258, 112);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(105, 13);
            this.label93.TabIndex = 107;
            this.label93.Text = "If abnormal, describe";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(58, 404);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 13);
            this.label34.TabIndex = 97;
            this.label34.Text = "Insertion site:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(42, 374);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 13);
            this.label33.TabIndex = 91;
            this.label33.Text = "Urinary catheter:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(53, 344);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 13);
            this.label32.TabIndex = 87;
            this.label32.Text = "Urinary stents:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(56, 314);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 13);
            this.label31.TabIndex = 79;
            this.label31.Text = "Stoma status:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(73, 284);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 75;
            this.label30.Text = "Urostomy:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 258);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 13);
            this.label29.TabIndex = 70;
            this.label29.Text = "Urine characterisitics:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(66, 228);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 62;
            this.label28.Text = "Urine color:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(54, 198);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 13);
            this.label27.TabIndex = 57;
            this.label27.Text = "Urine amount:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(72, 168);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "Continent:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 138);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 13);
            this.label25.TabIndex = 44;
            this.label25.Text = "Assessment of urination:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(76, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Genitalia:";
            // 
            // tabpageRespiratory
            // 
            this.tabpageRespiratory.AutoScroll = true;
            this.tabpageRespiratory.Controls.Add(this.label7);
            this.tabpageRespiratory.Controls.Add(this.bindingNavigator5);
            this.tabpageRespiratory.Controls.Add(this.btnNewResp);
            this.tabpageRespiratory.Controls.Add(this.btnSaveResp);
            this.tabpageRespiratory.Controls.Add(this.dateTimeTextBoxResp);
            this.tabpageRespiratory.Controls.Add(this.patientIDTextBoxResp);
            this.tabpageRespiratory.Controls.Add(this.respiratoryDyspneaTextBox);
            this.tabpageRespiratory.Controls.Add(this.ifOxygenCannulaTextBox);
            this.tabpageRespiratory.Controls.Add(this.ifColorOtherTextBox);
            this.tabpageRespiratory.Controls.Add(this.pulseOxWNLPatientTextBox);
            this.tabpageRespiratory.Controls.Add(dateTimeLabel1);
            this.tabpageRespiratory.Controls.Add(patientIDLabel1);
            this.tabpageRespiratory.Controls.Add(this.breathSoundsComboBox);
            this.tabpageRespiratory.Controls.Add(this.respiratoryRhythmComboBox);
            this.tabpageRespiratory.Controls.Add(this.respiratoryEffortComboBox);
            this.tabpageRespiratory.Controls.Add(this.respiratoryRateComboBox);
            this.tabpageRespiratory.Controls.Add(this.oxygenComboBox);
            this.tabpageRespiratory.Controls.Add(this.colorComboBox);
            this.tabpageRespiratory.Controls.Add(this.consistencyComboBox);
            this.tabpageRespiratory.Controls.Add(this.sputumComboBox);
            this.tabpageRespiratory.Controls.Add(this.coughComboBox);
            this.tabpageRespiratory.Controls.Add(this.pulseOxWNLComboBox);
            this.tabpageRespiratory.Controls.Add(this.label61);
            this.tabpageRespiratory.Controls.Add(this.label60);
            this.tabpageRespiratory.Controls.Add(this.label59);
            this.tabpageRespiratory.Controls.Add(this.label58);
            this.tabpageRespiratory.Controls.Add(this.label11);
            this.tabpageRespiratory.Controls.Add(this.label10);
            this.tabpageRespiratory.Controls.Add(this.label9);
            this.tabpageRespiratory.Controls.Add(this.label2);
            this.tabpageRespiratory.Controls.Add(this.label12);
            this.tabpageRespiratory.Controls.Add(this.label1);
            this.tabpageRespiratory.Controls.Add(this.label13);
            this.tabpageRespiratory.Controls.Add(this.label14);
            this.tabpageRespiratory.Controls.Add(this.label16);
            this.tabpageRespiratory.Controls.Add(this.label15);
            this.tabpageRespiratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpageRespiratory.Location = new System.Drawing.Point(4, 22);
            this.tabpageRespiratory.Name = "tabpageRespiratory";
            this.tabpageRespiratory.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageRespiratory.Size = new System.Drawing.Size(645, 528);
            this.tabpageRespiratory.TabIndex = 0;
            this.tabpageRespiratory.Text = "Respiratory";
            this.tabpageRespiratory.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 211;
            this.label7.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = null;
            this.bindingNavigator5.CountItem = this.bindingNavigatorCountItem7;
            this.bindingNavigator5.DeleteItem = null;
            this.bindingNavigator5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBackResp,
            this.bindingNavigatorMoveFirstItem7,
            this.bindingNavigatorMovePreviousItem7,
            this.bindingNavigatorSeparator21,
            this.bindingNavigatorPositionItem7,
            this.bindingNavigatorCountItem7,
            this.bindingNavigatorSeparator22,
            this.bindingNavigatorMoveNextItem7,
            this.bindingNavigatorMoveLastItem7,
            this.bindingNavigatorSeparator23,
            this.toolStripLabel6,
            this.tsTxtPtIDResp,
            this.tsBtnSearchResp});
            this.bindingNavigator5.Location = new System.Drawing.Point(3, 500);
            this.bindingNavigator5.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.bindingNavigator5.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.bindingNavigator5.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.bindingNavigator5.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.bindingNavigatorPositionItem7;
            this.bindingNavigator5.Size = new System.Drawing.Size(639, 25);
            this.bindingNavigator5.TabIndex = 194;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // bindingNavigatorCountItem7
            // 
            this.bindingNavigatorCountItem7.Name = "bindingNavigatorCountItem7";
            this.bindingNavigatorCountItem7.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem7.Text = "of {0}";
            this.bindingNavigatorCountItem7.ToolTipText = "Total number of items";
            // 
            // tsBtnBackResp
            // 
            this.tsBtnBackResp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBackResp.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBackResp.Image")));
            this.tsBtnBackResp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackResp.Name = "tsBtnBackResp";
            this.tsBtnBackResp.Size = new System.Drawing.Size(36, 22);
            this.tsBtnBackResp.Text = "Back";
            this.tsBtnBackResp.Click += new System.EventHandler(this.tsBtnBackResp_Click);
            // 
            // bindingNavigatorMoveFirstItem7
            // 
            this.bindingNavigatorMoveFirstItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem7.Image")));
            this.bindingNavigatorMoveFirstItem7.Name = "bindingNavigatorMoveFirstItem7";
            this.bindingNavigatorMoveFirstItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem7.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem7
            // 
            this.bindingNavigatorMovePreviousItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem7.Image")));
            this.bindingNavigatorMovePreviousItem7.Name = "bindingNavigatorMovePreviousItem7";
            this.bindingNavigatorMovePreviousItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem7.Text = "Move previous";
            // 
            // bindingNavigatorSeparator21
            // 
            this.bindingNavigatorSeparator21.Name = "bindingNavigatorSeparator21";
            this.bindingNavigatorSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem7
            // 
            this.bindingNavigatorPositionItem7.AccessibleName = "Position";
            this.bindingNavigatorPositionItem7.AutoSize = false;
            this.bindingNavigatorPositionItem7.Name = "bindingNavigatorPositionItem7";
            this.bindingNavigatorPositionItem7.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem7.Text = "0";
            this.bindingNavigatorPositionItem7.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator22
            // 
            this.bindingNavigatorSeparator22.Name = "bindingNavigatorSeparator22";
            this.bindingNavigatorSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem7
            // 
            this.bindingNavigatorMoveNextItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem7.Image")));
            this.bindingNavigatorMoveNextItem7.Name = "bindingNavigatorMoveNextItem7";
            this.bindingNavigatorMoveNextItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem7.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem7
            // 
            this.bindingNavigatorMoveLastItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem7.Image")));
            this.bindingNavigatorMoveLastItem7.Name = "bindingNavigatorMoveLastItem7";
            this.bindingNavigatorMoveLastItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem7.Text = "Move last";
            // 
            // bindingNavigatorSeparator23
            // 
            this.bindingNavigatorSeparator23.Name = "bindingNavigatorSeparator23";
            this.bindingNavigatorSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "Pt ID:";
            // 
            // tsTxtPtIDResp
            // 
            this.tsTxtPtIDResp.Name = "tsTxtPtIDResp";
            this.tsTxtPtIDResp.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnSearchResp
            // 
            this.tsBtnSearchResp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearchResp.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearchResp.Image")));
            this.tsBtnSearchResp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearchResp.Name = "tsBtnSearchResp";
            this.tsBtnSearchResp.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSearchResp.Text = "Search";
            this.tsBtnSearchResp.Click += new System.EventHandler(this.tsBtnSearchResp_Click);
            // 
            // btnNewResp
            // 
            this.btnNewResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewResp.Location = new System.Drawing.Point(263, 22);
            this.btnNewResp.Name = "btnNewResp";
            this.btnNewResp.Size = new System.Drawing.Size(75, 23);
            this.btnNewResp.TabIndex = 193;
            this.btnNewResp.Text = "New";
            this.btnNewResp.UseVisualStyleBackColor = true;
            this.btnNewResp.Click += new System.EventHandler(this.btnNewResp_Click);
            // 
            // btnSaveResp
            // 
            this.btnSaveResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResp.Location = new System.Drawing.Point(256, 454);
            this.btnSaveResp.Name = "btnSaveResp";
            this.btnSaveResp.Size = new System.Drawing.Size(75, 23);
            this.btnSaveResp.TabIndex = 192;
            this.btnSaveResp.Text = "Save";
            this.btnSaveResp.UseVisualStyleBackColor = true;
            this.btnSaveResp.Click += new System.EventHandler(this.btnSaveResp_Click);
            // 
            // dateTimeTextBoxResp
            // 
            this.dateTimeTextBoxResp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "DateTime", true));
            this.dateTimeTextBoxResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTextBoxResp.Location = new System.Drawing.Point(388, 62);
            this.dateTimeTextBoxResp.Name = "dateTimeTextBoxResp";
            this.dateTimeTextBoxResp.ReadOnly = true;
            this.dateTimeTextBoxResp.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTextBoxResp.TabIndex = 191;
            // 
            // patientIDTextBoxResp
            // 
            this.patientIDTextBoxResp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "PatientID", true));
            this.patientIDTextBoxResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTextBoxResp.Location = new System.Drawing.Point(205, 62);
            this.patientIDTextBoxResp.Name = "patientIDTextBoxResp";
            this.patientIDTextBoxResp.ReadOnly = true;
            this.patientIDTextBoxResp.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBoxResp.TabIndex = 189;
            this.patientIDTextBoxResp.Tag = "Patient ID";
            // 
            // respiratoryDyspneaTextBox
            // 
            this.respiratoryDyspneaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "RespiratoryDyspnea", true));
            this.respiratoryDyspneaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respiratoryDyspneaTextBox.Location = new System.Drawing.Point(340, 353);
            this.respiratoryDyspneaTextBox.Name = "respiratoryDyspneaTextBox";
            this.respiratoryDyspneaTextBox.ReadOnly = true;
            this.respiratoryDyspneaTextBox.Size = new System.Drawing.Size(100, 20);
            this.respiratoryDyspneaTextBox.TabIndex = 127;
            // 
            // ifOxygenCannulaTextBox
            // 
            this.ifOxygenCannulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "IfOxygenCannula", true));
            this.ifOxygenCannulaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifOxygenCannulaTextBox.Location = new System.Drawing.Point(340, 279);
            this.ifOxygenCannulaTextBox.Name = "ifOxygenCannulaTextBox";
            this.ifOxygenCannulaTextBox.ReadOnly = true;
            this.ifOxygenCannulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifOxygenCannulaTextBox.TabIndex = 125;
            // 
            // ifColorOtherTextBox
            // 
            this.ifColorOtherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "IfColorOther", true));
            this.ifColorOtherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifColorOtherTextBox.Location = new System.Drawing.Point(340, 248);
            this.ifColorOtherTextBox.Name = "ifColorOtherTextBox";
            this.ifColorOtherTextBox.ReadOnly = true;
            this.ifColorOtherTextBox.Size = new System.Drawing.Size(100, 20);
            this.ifColorOtherTextBox.TabIndex = 122;
            // 
            // pulseOxWNLPatientTextBox
            // 
            this.pulseOxWNLPatientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "PulseOxWNLPatient", true));
            this.pulseOxWNLPatientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseOxWNLPatientTextBox.Location = new System.Drawing.Point(348, 96);
            this.pulseOxWNLPatientTextBox.Name = "pulseOxWNLPatientTextBox";
            this.pulseOxWNLPatientTextBox.ReadOnly = true;
            this.pulseOxWNLPatientTextBox.Size = new System.Drawing.Size(100, 20);
            this.pulseOxWNLPatientTextBox.TabIndex = 117;
            // 
            // breathSoundsComboBox
            // 
            this.breathSoundsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "BreathSounds", true));
            this.breathSoundsComboBox.Enabled = false;
            this.breathSoundsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathSoundsComboBox.FormattingEnabled = true;
            this.breathSoundsComboBox.Items.AddRange(new object[] {
            "Clear throughout",
            "Decreased(atelectasis)",
            "Crackles",
            "Crackles: Fine",
            "Crackles: Moist",
            "Gurgles/rhonci",
            "Wheezes",
            "Wheeze: Inspiratory",
            "Wheeze: Expiratory",
            "Friction Rub",
            "Absent"});
            this.breathSoundsComboBox.Location = new System.Drawing.Point(108, 423);
            this.breathSoundsComboBox.Name = "breathSoundsComboBox";
            this.breathSoundsComboBox.Size = new System.Drawing.Size(121, 21);
            this.breathSoundsComboBox.TabIndex = 129;
            // 
            // respiratoryRhythmComboBox
            // 
            this.respiratoryRhythmComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "RespiratoryRhythm", true));
            this.respiratoryRhythmComboBox.Enabled = false;
            this.respiratoryRhythmComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respiratoryRhythmComboBox.FormattingEnabled = true;
            this.respiratoryRhythmComboBox.Items.AddRange(new object[] {
            "WNL",
            "Regular, tachypneic",
            "Regular, bradypneic",
            "Regular, apnea",
            "Irregular, ataxic"});
            this.respiratoryRhythmComboBox.Location = new System.Drawing.Point(108, 387);
            this.respiratoryRhythmComboBox.Name = "respiratoryRhythmComboBox";
            this.respiratoryRhythmComboBox.Size = new System.Drawing.Size(121, 21);
            this.respiratoryRhythmComboBox.TabIndex = 128;
            // 
            // respiratoryEffortComboBox
            // 
            this.respiratoryEffortComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "RespiratoryEffort", true));
            this.respiratoryEffortComboBox.Enabled = false;
            this.respiratoryEffortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respiratoryEffortComboBox.FormattingEnabled = true;
            this.respiratoryEffortComboBox.Items.AddRange(new object[] {
            "Relaxed and Regular",
            "Pursed Lip Breathing",
            "Painful Respiration",
            "Labored",
            "Dyspnea"});
            this.respiratoryEffortComboBox.Location = new System.Drawing.Point(108, 351);
            this.respiratoryEffortComboBox.Name = "respiratoryEffortComboBox";
            this.respiratoryEffortComboBox.Size = new System.Drawing.Size(121, 21);
            this.respiratoryEffortComboBox.TabIndex = 126;
            // 
            // respiratoryRateComboBox
            // 
            this.respiratoryRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "RespiratoryRate", true));
            this.respiratoryRateComboBox.Enabled = false;
            this.respiratoryRateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respiratoryRateComboBox.FormattingEnabled = true;
            this.respiratoryRateComboBox.Items.AddRange(new object[] {
            "WNL",
            "Tachypnea",
            "Bradypneic"});
            this.respiratoryRateComboBox.Location = new System.Drawing.Point(108, 315);
            this.respiratoryRateComboBox.Name = "respiratoryRateComboBox";
            this.respiratoryRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.respiratoryRateComboBox.TabIndex = 124;
            // 
            // oxygenComboBox
            // 
            this.oxygenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "Oxygen", true));
            this.oxygenComboBox.Enabled = false;
            this.oxygenComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oxygenComboBox.FormattingEnabled = true;
            this.oxygenComboBox.Items.AddRange(new object[] {
            "RA",
            "liters/nasal cannula",
            "% per face mask",
            "Mechanical Ventilator"});
            this.oxygenComboBox.Location = new System.Drawing.Point(108, 279);
            this.oxygenComboBox.Name = "oxygenComboBox";
            this.oxygenComboBox.Size = new System.Drawing.Size(121, 21);
            this.oxygenComboBox.TabIndex = 123;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "Color", true));
            this.colorComboBox.Enabled = false;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "White",
            "Other"});
            this.colorComboBox.Location = new System.Drawing.Point(108, 243);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 121;
            // 
            // consistencyComboBox
            // 
            this.consistencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "Consistency", true));
            this.consistencyComboBox.Enabled = false;
            this.consistencyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consistencyComboBox.FormattingEnabled = true;
            this.consistencyComboBox.Items.AddRange(new object[] {
            "Thick",
            "Thin",
            "Foamy"});
            this.consistencyComboBox.Location = new System.Drawing.Point(108, 207);
            this.consistencyComboBox.Name = "consistencyComboBox";
            this.consistencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.consistencyComboBox.TabIndex = 120;
            // 
            // sputumComboBox
            // 
            this.sputumComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "Sputum", true));
            this.sputumComboBox.Enabled = false;
            this.sputumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sputumComboBox.FormattingEnabled = true;
            this.sputumComboBox.Items.AddRange(new object[] {
            "Present",
            "None"});
            this.sputumComboBox.Location = new System.Drawing.Point(108, 171);
            this.sputumComboBox.Name = "sputumComboBox";
            this.sputumComboBox.Size = new System.Drawing.Size(121, 21);
            this.sputumComboBox.TabIndex = 119;
            // 
            // coughComboBox
            // 
            this.coughComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "Cough", true));
            this.coughComboBox.Enabled = false;
            this.coughComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coughComboBox.FormattingEnabled = true;
            this.coughComboBox.Items.AddRange(new object[] {
            "None",
            "Non-productive,dry",
            "Productive",
            "Productive, no sputum"});
            this.coughComboBox.Location = new System.Drawing.Point(108, 135);
            this.coughComboBox.Name = "coughComboBox";
            this.coughComboBox.Size = new System.Drawing.Size(121, 21);
            this.coughComboBox.TabIndex = 118;
            // 
            // pulseOxWNLComboBox
            // 
            this.pulseOxWNLComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respiratoryBindingSource, "PulseOxWNL", true));
            this.pulseOxWNLComboBox.Enabled = false;
            this.pulseOxWNLComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseOxWNLComboBox.FormattingEnabled = true;
            this.pulseOxWNLComboBox.Items.AddRange(new object[] {
            "WNL(95-100%)",
            "WNL for pt at"});
            this.pulseOxWNLComboBox.Location = new System.Drawing.Point(108, 99);
            this.pulseOxWNLComboBox.Name = "pulseOxWNLComboBox";
            this.pulseOxWNLComboBox.Size = new System.Drawing.Size(121, 21);
            this.pulseOxWNLComboBox.TabIndex = 116;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(253, 104);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(87, 13);
            this.label61.TabIndex = 115;
            this.label61.Text = "If WNL, describe";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(232, 357);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(104, 13);
            this.label60.TabIndex = 113;
            this.label60.Text = "If Dyspnea, describe";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(232, 249);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(86, 13);
            this.label59.TabIndex = 111;
            this.label59.Text = "If other, describe";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(232, 285);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(106, 13);
            this.label58.TabIndex = 109;
            this.label58.Text = "If liters of %, describe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cough:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sputum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pulse ox:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Breath Sounds:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Sputum Consistency:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Respiratory rhythm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Color:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Oxygen:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Respiratory effort:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Respiratory rate:";
            // 
            // tabpageNeuro
            // 
            this.tabpageNeuro.AutoScroll = true;
            this.tabpageNeuro.Controls.Add(this.label6);
            this.tabpageNeuro.Controls.Add(this.bindingNavigator6);
            this.tabpageNeuro.Controls.Add(this.btnSaveNeuro);
            this.tabpageNeuro.Controls.Add(this.btnNewNeuro);
            this.tabpageNeuro.Controls.Add(this.dateTimeTextBoxNeuro);
            this.tabpageNeuro.Controls.Add(this.patientIDTextBoxNeuro);
            this.tabpageNeuro.Controls.Add(dateTimeLabel);
            this.tabpageNeuro.Controls.Add(patientIDLabel);
            this.tabpageNeuro.Controls.Add(this.locLLETRComboBox);
            this.tabpageNeuro.Controls.Add(this.locRLETRComboBox);
            this.tabpageNeuro.Controls.Add(this.locLueTRComboBox);
            this.tabpageNeuro.Controls.Add(this.locRueTRComboBox);
            this.tabpageNeuro.Controls.Add(this.locLHandTRComboBox);
            this.tabpageNeuro.Controls.Add(this.locRHandTRComboBox);
            this.tabpageNeuro.Controls.Add(this.locHeadNeckTRComboBox);
            this.tabpageNeuro.Controls.Add(this.locLLESEComboBox);
            this.tabpageNeuro.Controls.Add(this.locRLESEComboBox);
            this.tabpageNeuro.Controls.Add(this.locLueSEComboBox);
            this.tabpageNeuro.Controls.Add(this.locRueSEComboBox);
            this.tabpageNeuro.Controls.Add(this.locLHandSEComboBox);
            this.tabpageNeuro.Controls.Add(this.locRHandSEComboBox);
            this.tabpageNeuro.Controls.Add(this.locHeadNeckSEComboBox);
            this.tabpageNeuro.Controls.Add(this.locLLEMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locRLEMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locLueMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locRueMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locLHandMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locRHandMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locHeadNeckMusStComboBox);
            this.tabpageNeuro.Controls.Add(this.locLLEMTComboBox);
            this.tabpageNeuro.Controls.Add(this.locRLEMTComboBox);
            this.tabpageNeuro.Controls.Add(this.locLueMTComboBox);
            this.tabpageNeuro.Controls.Add(this.locRueMTComboBox);
            this.tabpageNeuro.Controls.Add(this.locLHandMTComboBox);
            this.tabpageNeuro.Controls.Add(this.locRHandMTComboBox);
            this.tabpageNeuro.Controls.Add(this.locHeadNeckMTComboBox);
            this.tabpageNeuro.Controls.Add(this.comSpeechComboBox);
            this.tabpageNeuro.Controls.Add(this.orientedToTimeCheckBox);
            this.tabpageNeuro.Controls.Add(this.orientedToPLCheckBox);
            this.tabpageNeuro.Controls.Add(this.orientedToPERCheckBox);
            this.tabpageNeuro.Controls.Add(this.label56);
            this.tabpageNeuro.Controls.Add(this.label55);
            this.tabpageNeuro.Controls.Add(this.label54);
            this.tabpageNeuro.Controls.Add(this.label53);
            this.tabpageNeuro.Controls.Add(this.label52);
            this.tabpageNeuro.Controls.Add(this.label51);
            this.tabpageNeuro.Controls.Add(this.label50);
            this.tabpageNeuro.Controls.Add(this.label49);
            this.tabpageNeuro.Controls.Add(this.label48);
            this.tabpageNeuro.Controls.Add(this.label47);
            this.tabpageNeuro.Controls.Add(this.label46);
            this.tabpageNeuro.Controls.Add(this.label45);
            this.tabpageNeuro.Controls.Add(this.label44);
            this.tabpageNeuro.Controls.Add(this.label3);
            this.tabpageNeuro.Controls.Add(this.label5);
            this.tabpageNeuro.Location = new System.Drawing.Point(4, 22);
            this.tabpageNeuro.Name = "tabpageNeuro";
            this.tabpageNeuro.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNeuro.Size = new System.Drawing.Size(645, 528);
            this.tabpageNeuro.TabIndex = 1;
            this.tabpageNeuro.Text = "Neurological";
            this.tabpageNeuro.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 210;
            this.label6.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // bindingNavigator6
            // 
            this.bindingNavigator6.AddNewItem = null;
            this.bindingNavigator6.CountItem = this.bindingNavigatorCountItem8;
            this.bindingNavigator6.DeleteItem = null;
            this.bindingNavigator6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBackNeuro,
            this.bindingNavigatorMoveFirstItem8,
            this.bindingNavigatorMovePreviousItem8,
            this.bindingNavigatorSeparator24,
            this.bindingNavigatorPositionItem8,
            this.bindingNavigatorCountItem8,
            this.bindingNavigatorSeparator25,
            this.bindingNavigatorMoveNextItem8,
            this.bindingNavigatorMoveLastItem8,
            this.bindingNavigatorSeparator26,
            this.toolStripLabel7,
            this.tsTxtPtIDNeuro,
            this.tsBtnSearchNeuro});
            this.bindingNavigator6.Location = new System.Drawing.Point(3, 500);
            this.bindingNavigator6.MoveFirstItem = this.bindingNavigatorMoveFirstItem8;
            this.bindingNavigator6.MoveLastItem = this.bindingNavigatorMoveLastItem8;
            this.bindingNavigator6.MoveNextItem = this.bindingNavigatorMoveNextItem8;
            this.bindingNavigator6.MovePreviousItem = this.bindingNavigatorMovePreviousItem8;
            this.bindingNavigator6.Name = "bindingNavigator6";
            this.bindingNavigator6.PositionItem = this.bindingNavigatorPositionItem8;
            this.bindingNavigator6.Size = new System.Drawing.Size(639, 25);
            this.bindingNavigator6.TabIndex = 209;
            this.bindingNavigator6.Text = "bindingNavigator6";
            // 
            // bindingNavigatorCountItem8
            // 
            this.bindingNavigatorCountItem8.Name = "bindingNavigatorCountItem8";
            this.bindingNavigatorCountItem8.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem8.Text = "of {0}";
            this.bindingNavigatorCountItem8.ToolTipText = "Total number of items";
            // 
            // tsBtnBackNeuro
            // 
            this.tsBtnBackNeuro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBackNeuro.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBackNeuro.Image")));
            this.tsBtnBackNeuro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackNeuro.Name = "tsBtnBackNeuro";
            this.tsBtnBackNeuro.Size = new System.Drawing.Size(36, 22);
            this.tsBtnBackNeuro.Text = "Back";
            this.tsBtnBackNeuro.Click += new System.EventHandler(this.tsBtnBackNeuro_Click);
            // 
            // bindingNavigatorMoveFirstItem8
            // 
            this.bindingNavigatorMoveFirstItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem8.Image")));
            this.bindingNavigatorMoveFirstItem8.Name = "bindingNavigatorMoveFirstItem8";
            this.bindingNavigatorMoveFirstItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem8.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem8
            // 
            this.bindingNavigatorMovePreviousItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem8.Image")));
            this.bindingNavigatorMovePreviousItem8.Name = "bindingNavigatorMovePreviousItem8";
            this.bindingNavigatorMovePreviousItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem8.Text = "Move previous";
            // 
            // bindingNavigatorSeparator24
            // 
            this.bindingNavigatorSeparator24.Name = "bindingNavigatorSeparator24";
            this.bindingNavigatorSeparator24.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem8
            // 
            this.bindingNavigatorPositionItem8.AccessibleName = "Position";
            this.bindingNavigatorPositionItem8.AutoSize = false;
            this.bindingNavigatorPositionItem8.Name = "bindingNavigatorPositionItem8";
            this.bindingNavigatorPositionItem8.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem8.Text = "0";
            this.bindingNavigatorPositionItem8.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator25
            // 
            this.bindingNavigatorSeparator25.Name = "bindingNavigatorSeparator25";
            this.bindingNavigatorSeparator25.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem8
            // 
            this.bindingNavigatorMoveNextItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem8.Image")));
            this.bindingNavigatorMoveNextItem8.Name = "bindingNavigatorMoveNextItem8";
            this.bindingNavigatorMoveNextItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem8.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem8
            // 
            this.bindingNavigatorMoveLastItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem8.Image")));
            this.bindingNavigatorMoveLastItem8.Name = "bindingNavigatorMoveLastItem8";
            this.bindingNavigatorMoveLastItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem8.Text = "Move last";
            // 
            // bindingNavigatorSeparator26
            // 
            this.bindingNavigatorSeparator26.Name = "bindingNavigatorSeparator26";
            this.bindingNavigatorSeparator26.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel7.Text = "Pt ID:";
            // 
            // tsTxtPtIDNeuro
            // 
            this.tsTxtPtIDNeuro.Name = "tsTxtPtIDNeuro";
            this.tsTxtPtIDNeuro.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnSearchNeuro
            // 
            this.tsBtnSearchNeuro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSearchNeuro.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSearchNeuro.Image")));
            this.tsBtnSearchNeuro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearchNeuro.Name = "tsBtnSearchNeuro";
            this.tsBtnSearchNeuro.Size = new System.Drawing.Size(46, 22);
            this.tsBtnSearchNeuro.Text = "Search";
            this.tsBtnSearchNeuro.Click += new System.EventHandler(this.tsBtnSearchNeuro_Click);
            // 
            // btnSaveNeuro
            // 
            this.btnSaveNeuro.Location = new System.Drawing.Point(279, 365);
            this.btnSaveNeuro.Name = "btnSaveNeuro";
            this.btnSaveNeuro.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNeuro.TabIndex = 44;
            this.btnSaveNeuro.Text = "Save";
            this.btnSaveNeuro.UseVisualStyleBackColor = true;
            this.btnSaveNeuro.Click += new System.EventHandler(this.btnSaveNeuro_Click);
            // 
            // btnNewNeuro
            // 
            this.btnNewNeuro.Location = new System.Drawing.Point(269, 6);
            this.btnNewNeuro.Name = "btnNewNeuro";
            this.btnNewNeuro.Size = new System.Drawing.Size(75, 23);
            this.btnNewNeuro.TabIndex = 0;
            this.btnNewNeuro.Text = "New";
            this.btnNewNeuro.UseVisualStyleBackColor = true;
            this.btnNewNeuro.Click += new System.EventHandler(this.btnNewNeuro_Click);
            // 
            // dateTimeTextBoxNeuro
            // 
            this.dateTimeTextBoxNeuro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "DateTime", true));
            this.dateTimeTextBoxNeuro.Location = new System.Drawing.Point(373, 42);
            this.dateTimeTextBoxNeuro.Name = "dateTimeTextBoxNeuro";
            this.dateTimeTextBoxNeuro.ReadOnly = true;
            this.dateTimeTextBoxNeuro.Size = new System.Drawing.Size(127, 20);
            this.dateTimeTextBoxNeuro.TabIndex = 2;
            // 
            // patientIDTextBoxNeuro
            // 
            this.patientIDTextBoxNeuro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "PatientID", true));
            this.patientIDTextBoxNeuro.Location = new System.Drawing.Point(183, 42);
            this.patientIDTextBoxNeuro.Name = "patientIDTextBoxNeuro";
            this.patientIDTextBoxNeuro.ReadOnly = true;
            this.patientIDTextBoxNeuro.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBoxNeuro.TabIndex = 1;
            this.patientIDTextBoxNeuro.Tag = "Patient ID";
            // 
            // locLLETRComboBox
            // 
            this.locLLETRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLLETR", true));
            this.locLLETRComboBox.Enabled = false;
            this.locLLETRComboBox.FormattingEnabled = true;
            this.locLLETRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locLLETRComboBox.Location = new System.Drawing.Point(435, 321);
            this.locLLETRComboBox.Name = "locLLETRComboBox";
            this.locLLETRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locLLETRComboBox.TabIndex = 43;
            // 
            // locRLETRComboBox
            // 
            this.locRLETRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRLETR", true));
            this.locRLETRComboBox.Enabled = false;
            this.locRLETRComboBox.FormattingEnabled = true;
            this.locRLETRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locRLETRComboBox.Location = new System.Drawing.Point(435, 294);
            this.locRLETRComboBox.Name = "locRLETRComboBox";
            this.locRLETRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locRLETRComboBox.TabIndex = 42;
            // 
            // locLueTRComboBox
            // 
            this.locLueTRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLueTR", true));
            this.locLueTRComboBox.Enabled = false;
            this.locLueTRComboBox.FormattingEnabled = true;
            this.locLueTRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locLueTRComboBox.Location = new System.Drawing.Point(435, 267);
            this.locLueTRComboBox.Name = "locLueTRComboBox";
            this.locLueTRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locLueTRComboBox.TabIndex = 41;
            // 
            // locRueTRComboBox
            // 
            this.locRueTRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRueTR", true));
            this.locRueTRComboBox.Enabled = false;
            this.locRueTRComboBox.FormattingEnabled = true;
            this.locRueTRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locRueTRComboBox.Location = new System.Drawing.Point(435, 240);
            this.locRueTRComboBox.Name = "locRueTRComboBox";
            this.locRueTRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locRueTRComboBox.TabIndex = 40;
            // 
            // locLHandTRComboBox
            // 
            this.locLHandTRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLHandTR", true));
            this.locLHandTRComboBox.Enabled = false;
            this.locLHandTRComboBox.FormattingEnabled = true;
            this.locLHandTRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locLHandTRComboBox.Location = new System.Drawing.Point(435, 213);
            this.locLHandTRComboBox.Name = "locLHandTRComboBox";
            this.locLHandTRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locLHandTRComboBox.TabIndex = 39;
            // 
            // locRHandTRComboBox
            // 
            this.locRHandTRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRHandTR", true));
            this.locRHandTRComboBox.Enabled = false;
            this.locRHandTRComboBox.FormattingEnabled = true;
            this.locRHandTRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locRHandTRComboBox.Location = new System.Drawing.Point(435, 186);
            this.locRHandTRComboBox.Name = "locRHandTRComboBox";
            this.locRHandTRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locRHandTRComboBox.TabIndex = 38;
            // 
            // locHeadNeckTRComboBox
            // 
            this.locHeadNeckTRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocHeadNeckTR", true));
            this.locHeadNeckTRComboBox.Enabled = false;
            this.locHeadNeckTRComboBox.FormattingEnabled = true;
            this.locHeadNeckTRComboBox.Items.AddRange(new object[] {
            "No",
            "Present"});
            this.locHeadNeckTRComboBox.Location = new System.Drawing.Point(435, 159);
            this.locHeadNeckTRComboBox.Name = "locHeadNeckTRComboBox";
            this.locHeadNeckTRComboBox.Size = new System.Drawing.Size(65, 21);
            this.locHeadNeckTRComboBox.TabIndex = 37;
            // 
            // locLLESEComboBox
            // 
            this.locLLESEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLLESE", true));
            this.locLLESEComboBox.Enabled = false;
            this.locLLESEComboBox.FormattingEnabled = true;
            this.locLLESEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locLLESEComboBox.Location = new System.Drawing.Point(340, 317);
            this.locLLESEComboBox.Name = "locLLESEComboBox";
            this.locLLESEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locLLESEComboBox.TabIndex = 36;
            // 
            // locRLESEComboBox
            // 
            this.locRLESEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRLESE", true));
            this.locRLESEComboBox.Enabled = false;
            this.locRLESEComboBox.FormattingEnabled = true;
            this.locRLESEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locRLESEComboBox.Location = new System.Drawing.Point(340, 291);
            this.locRLESEComboBox.Name = "locRLESEComboBox";
            this.locRLESEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locRLESEComboBox.TabIndex = 35;
            // 
            // locLueSEComboBox
            // 
            this.locLueSEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLueSE", true));
            this.locLueSEComboBox.Enabled = false;
            this.locLueSEComboBox.FormattingEnabled = true;
            this.locLueSEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locLueSEComboBox.Location = new System.Drawing.Point(340, 265);
            this.locLueSEComboBox.Name = "locLueSEComboBox";
            this.locLueSEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locLueSEComboBox.TabIndex = 34;
            // 
            // locRueSEComboBox
            // 
            this.locRueSEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRueSE", true));
            this.locRueSEComboBox.Enabled = false;
            this.locRueSEComboBox.FormattingEnabled = true;
            this.locRueSEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locRueSEComboBox.Location = new System.Drawing.Point(340, 239);
            this.locRueSEComboBox.Name = "locRueSEComboBox";
            this.locRueSEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locRueSEComboBox.TabIndex = 33;
            // 
            // locLHandSEComboBox
            // 
            this.locLHandSEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLHandSE", true));
            this.locLHandSEComboBox.Enabled = false;
            this.locLHandSEComboBox.FormattingEnabled = true;
            this.locLHandSEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locLHandSEComboBox.Location = new System.Drawing.Point(340, 213);
            this.locLHandSEComboBox.Name = "locLHandSEComboBox";
            this.locLHandSEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locLHandSEComboBox.TabIndex = 32;
            // 
            // locRHandSEComboBox
            // 
            this.locRHandSEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRHandSE", true));
            this.locRHandSEComboBox.Enabled = false;
            this.locRHandSEComboBox.FormattingEnabled = true;
            this.locRHandSEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locRHandSEComboBox.Location = new System.Drawing.Point(340, 187);
            this.locRHandSEComboBox.Name = "locRHandSEComboBox";
            this.locRHandSEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locRHandSEComboBox.TabIndex = 31;
            // 
            // locHeadNeckSEComboBox
            // 
            this.locHeadNeckSEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocHeadNeckSE", true));
            this.locHeadNeckSEComboBox.Enabled = false;
            this.locHeadNeckSEComboBox.FormattingEnabled = true;
            this.locHeadNeckSEComboBox.Items.AddRange(new object[] {
            "WNL",
            "To pain",
            "No response to pain"});
            this.locHeadNeckSEComboBox.Location = new System.Drawing.Point(340, 161);
            this.locHeadNeckSEComboBox.Name = "locHeadNeckSEComboBox";
            this.locHeadNeckSEComboBox.Size = new System.Drawing.Size(89, 21);
            this.locHeadNeckSEComboBox.TabIndex = 30;
            // 
            // locLLEMusStComboBox
            // 
            this.locLLEMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLLEMusSt", true));
            this.locLLEMusStComboBox.Enabled = false;
            this.locLLEMusStComboBox.FormattingEnabled = true;
            this.locLLEMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locLLEMusStComboBox.Location = new System.Drawing.Point(281, 318);
            this.locLLEMusStComboBox.Name = "locLLEMusStComboBox";
            this.locLLEMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locLLEMusStComboBox.TabIndex = 29;
            // 
            // locRLEMusStComboBox
            // 
            this.locRLEMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRLEMusSt", true));
            this.locRLEMusStComboBox.Enabled = false;
            this.locRLEMusStComboBox.FormattingEnabled = true;
            this.locRLEMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locRLEMusStComboBox.Location = new System.Drawing.Point(281, 292);
            this.locRLEMusStComboBox.Name = "locRLEMusStComboBox";
            this.locRLEMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locRLEMusStComboBox.TabIndex = 28;
            // 
            // locLueMusStComboBox
            // 
            this.locLueMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLueMusSt", true));
            this.locLueMusStComboBox.Enabled = false;
            this.locLueMusStComboBox.FormattingEnabled = true;
            this.locLueMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locLueMusStComboBox.Location = new System.Drawing.Point(281, 266);
            this.locLueMusStComboBox.Name = "locLueMusStComboBox";
            this.locLueMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locLueMusStComboBox.TabIndex = 27;
            // 
            // locRueMusStComboBox
            // 
            this.locRueMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRueMusSt", true));
            this.locRueMusStComboBox.Enabled = false;
            this.locRueMusStComboBox.FormattingEnabled = true;
            this.locRueMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locRueMusStComboBox.Location = new System.Drawing.Point(281, 240);
            this.locRueMusStComboBox.Name = "locRueMusStComboBox";
            this.locRueMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locRueMusStComboBox.TabIndex = 26;
            // 
            // locLHandMusStComboBox
            // 
            this.locLHandMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLHandMusSt", true));
            this.locLHandMusStComboBox.Enabled = false;
            this.locLHandMusStComboBox.FormattingEnabled = true;
            this.locLHandMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locLHandMusStComboBox.Location = new System.Drawing.Point(281, 214);
            this.locLHandMusStComboBox.Name = "locLHandMusStComboBox";
            this.locLHandMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locLHandMusStComboBox.TabIndex = 25;
            // 
            // locRHandMusStComboBox
            // 
            this.locRHandMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRHandMusSt", true));
            this.locRHandMusStComboBox.Enabled = false;
            this.locRHandMusStComboBox.FormattingEnabled = true;
            this.locRHandMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locRHandMusStComboBox.Location = new System.Drawing.Point(281, 188);
            this.locRHandMusStComboBox.Name = "locRHandMusStComboBox";
            this.locRHandMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locRHandMusStComboBox.TabIndex = 24;
            // 
            // locHeadNeckMusStComboBox
            // 
            this.locHeadNeckMusStComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocHeadNeckMusSt", true));
            this.locHeadNeckMusStComboBox.Enabled = false;
            this.locHeadNeckMusStComboBox.FormattingEnabled = true;
            this.locHeadNeckMusStComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.locHeadNeckMusStComboBox.Location = new System.Drawing.Point(281, 162);
            this.locHeadNeckMusStComboBox.Name = "locHeadNeckMusStComboBox";
            this.locHeadNeckMusStComboBox.Size = new System.Drawing.Size(35, 21);
            this.locHeadNeckMusStComboBox.TabIndex = 23;
            // 
            // locLLEMTComboBox
            // 
            this.locLLEMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLLEMT", true));
            this.locLLEMTComboBox.Enabled = false;
            this.locLLEMTComboBox.FormattingEnabled = true;
            this.locLLEMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locLLEMTComboBox.Location = new System.Drawing.Point(172, 317);
            this.locLLEMTComboBox.Name = "locLLEMTComboBox";
            this.locLLEMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locLLEMTComboBox.TabIndex = 22;
            // 
            // locRLEMTComboBox
            // 
            this.locRLEMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRLEMT", true));
            this.locRLEMTComboBox.Enabled = false;
            this.locRLEMTComboBox.FormattingEnabled = true;
            this.locRLEMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locRLEMTComboBox.Location = new System.Drawing.Point(172, 291);
            this.locRLEMTComboBox.Name = "locRLEMTComboBox";
            this.locRLEMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locRLEMTComboBox.TabIndex = 21;
            // 
            // locLueMTComboBox
            // 
            this.locLueMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLueMT", true));
            this.locLueMTComboBox.Enabled = false;
            this.locLueMTComboBox.FormattingEnabled = true;
            this.locLueMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locLueMTComboBox.Location = new System.Drawing.Point(172, 268);
            this.locLueMTComboBox.Name = "locLueMTComboBox";
            this.locLueMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locLueMTComboBox.TabIndex = 20;
            // 
            // locRueMTComboBox
            // 
            this.locRueMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRueMT", true));
            this.locRueMTComboBox.Enabled = false;
            this.locRueMTComboBox.FormattingEnabled = true;
            this.locRueMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locRueMTComboBox.Location = new System.Drawing.Point(172, 241);
            this.locRueMTComboBox.Name = "locRueMTComboBox";
            this.locRueMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locRueMTComboBox.TabIndex = 19;
            // 
            // locLHandMTComboBox
            // 
            this.locLHandMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocLHandMT", true));
            this.locLHandMTComboBox.Enabled = false;
            this.locLHandMTComboBox.FormattingEnabled = true;
            this.locLHandMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locLHandMTComboBox.Location = new System.Drawing.Point(172, 213);
            this.locLHandMTComboBox.Name = "locLHandMTComboBox";
            this.locLHandMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locLHandMTComboBox.TabIndex = 18;
            // 
            // locRHandMTComboBox
            // 
            this.locRHandMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocRHandMT", true));
            this.locRHandMTComboBox.Enabled = false;
            this.locRHandMTComboBox.FormattingEnabled = true;
            this.locRHandMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locRHandMTComboBox.Location = new System.Drawing.Point(172, 188);
            this.locRHandMTComboBox.Name = "locRHandMTComboBox";
            this.locRHandMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locRHandMTComboBox.TabIndex = 17;
            // 
            // locHeadNeckMTComboBox
            // 
            this.locHeadNeckMTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "LocHeadNeckMT", true));
            this.locHeadNeckMTComboBox.Enabled = false;
            this.locHeadNeckMTComboBox.FormattingEnabled = true;
            this.locHeadNeckMTComboBox.Items.AddRange(new object[] {
            "WNL",
            "Flaccid",
            "Spastic"});
            this.locHeadNeckMTComboBox.Location = new System.Drawing.Point(172, 163);
            this.locHeadNeckMTComboBox.Name = "locHeadNeckMTComboBox";
            this.locHeadNeckMTComboBox.Size = new System.Drawing.Size(90, 21);
            this.locHeadNeckMTComboBox.TabIndex = 16;
            // 
            // comSpeechComboBox
            // 
            this.comSpeechComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neurologicalBindingSource, "ComSpeech", true));
            this.comSpeechComboBox.Enabled = false;
            this.comSpeechComboBox.FormattingEnabled = true;
            this.comSpeechComboBox.Items.AddRange(new object[] {
            "WNL",
            "Non-verbal",
            "Dysarthria",
            "Aphasia"});
            this.comSpeechComboBox.Location = new System.Drawing.Point(128, 108);
            this.comSpeechComboBox.Name = "comSpeechComboBox";
            this.comSpeechComboBox.Size = new System.Drawing.Size(121, 21);
            this.comSpeechComboBox.TabIndex = 6;
            // 
            // orientedToTimeCheckBox
            // 
            this.orientedToTimeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.neurologicalBindingSource, "OrientedToTime", true));
            this.orientedToTimeCheckBox.Enabled = false;
            this.orientedToTimeCheckBox.Location = new System.Drawing.Point(193, 78);
            this.orientedToTimeCheckBox.Name = "orientedToTimeCheckBox";
            this.orientedToTimeCheckBox.Size = new System.Drawing.Size(62, 24);
            this.orientedToTimeCheckBox.TabIndex = 5;
            this.orientedToTimeCheckBox.Text = "Time";
            this.orientedToTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // orientedToPLCheckBox
            // 
            this.orientedToPLCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.neurologicalBindingSource, "OrientedToPL", true));
            this.orientedToPLCheckBox.Enabled = false;
            this.orientedToPLCheckBox.Location = new System.Drawing.Point(137, 79);
            this.orientedToPLCheckBox.Name = "orientedToPLCheckBox";
            this.orientedToPLCheckBox.Size = new System.Drawing.Size(62, 24);
            this.orientedToPLCheckBox.TabIndex = 4;
            this.orientedToPLCheckBox.Text = "Place";
            this.orientedToPLCheckBox.UseVisualStyleBackColor = true;
            // 
            // orientedToPERCheckBox
            // 
            this.orientedToPERCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.neurologicalBindingSource, "OrientedToPER", true));
            this.orientedToPERCheckBox.Enabled = false;
            this.orientedToPERCheckBox.Location = new System.Drawing.Point(71, 79);
            this.orientedToPERCheckBox.Name = "orientedToPERCheckBox";
            this.orientedToPERCheckBox.Size = new System.Drawing.Size(62, 24);
            this.orientedToPERCheckBox.TabIndex = 3;
            this.orientedToPERCheckBox.Text = "Person";
            this.orientedToPERCheckBox.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(441, 143);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(40, 13);
            this.label56.TabIndex = 154;
            this.label56.Text = "Tremor";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(364, 143);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(54, 13);
            this.label55.TabIndex = 146;
            this.label55.Text = "Sensation";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(270, 143);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(84, 13);
            this.label54.TabIndex = 138;
            this.label54.Text = "Muscle Strength";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(184, 143);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(69, 13);
            this.label53.TabIndex = 137;
            this.label53.Text = "Muscle Tone";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(124, 220);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(42, 13);
            this.label52.TabIndex = 130;
            this.label52.Text = "L Hand";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(136, 246);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 13);
            this.label51.TabIndex = 129;
            this.label51.Text = "RUE";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(138, 273);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(28, 13);
            this.label50.TabIndex = 128;
            this.label50.Text = "LUE";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(138, 299);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(28, 13);
            this.label49.TabIndex = 127;
            this.label49.Text = "RLE";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(140, 325);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(26, 13);
            this.label48.TabIndex = 126;
            this.label48.Text = "LLE";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(122, 193);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 13);
            this.label47.TabIndex = 125;
            this.label47.Text = "R Hand";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(102, 167);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(64, 13);
            this.label46.TabIndex = 124;
            this.label46.Text = "Head/Neck";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(235, 349);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(318, 13);
            this.label45.TabIndex = 123;
            this.label45.Text = "5 = WNL 4 = 75% 3 = 50% 2 = 25% 1= 10% 0 = complete paralysis";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(121, 347);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(115, 15);
            this.label44.TabIndex = 122;
            this.label44.Text = "Muscle Strength:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oriented to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Communication/Speech:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpageNeuro);
            this.tabControl1.Controls.Add(this.tabpageRespiratory);
            this.tabControl1.Controls.Add(this.tabpageUrinary);
            this.tabControl1.Controls.Add(this.tabpageGastro);
            this.tabControl1.Controls.Add(this.tabpageSkin);
            this.tabControl1.Controls.Add(this.tabpageIV);
            this.tabControl1.Controls.Add(this.tabpageExtrimety);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(578, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(369, 75);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(154, 13);
            this.label38.TabIndex = 211;
            this.label38.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(361, 110);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(154, 13);
            this.label39.TabIndex = 211;
            this.label39.Text = "(Example: 4/25/2012 5:37 PM)";
            // 
            // frmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssessment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment";
            this.Load += new System.EventHandler(this.frmAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.neurologicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstone_Project_FinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiratoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardiovascularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genitourinaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastrointestinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinIntegrityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intravenousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cast_Extremity_AssessmentBindingSource)).EndInit();
            this.tabpageExtrimety.ResumeLayout(false);
            this.tabpageExtrimety.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cast_Extremity_AssessmentBindingNavigator)).EndInit();
            this.cast_Extremity_AssessmentBindingNavigator.ResumeLayout(false);
            this.cast_Extremity_AssessmentBindingNavigator.PerformLayout();
            this.tabpageIV.ResumeLayout(false);
            this.tabpageIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorIV)).EndInit();
            this.bindingNavigatorIV.ResumeLayout(false);
            this.bindingNavigatorIV.PerformLayout();
            this.tabpageSkin.ResumeLayout(false);
            this.tabpageSkin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabpageGastro.ResumeLayout(false);
            this.tabpageGastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabpageUrinary.ResumeLayout(false);
            this.tabpageUrinary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.tabpageRespiratory.ResumeLayout(false);
            this.tabpageRespiratory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            this.tabpageNeuro.ResumeLayout(false);
            this.tabpageNeuro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).EndInit();
            this.bindingNavigator6.ResumeLayout(false);
            this.bindingNavigator6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Capstone_Project_FinalDataSet capstone_Project_FinalDataSet;
        private System.Windows.Forms.BindingSource cast_Extremity_AssessmentBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.Cast_Extremity_AssessmentTableAdapter cast_Extremity_AssessmentTableAdapter;
        private Capstone_Project_FinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource intravenousBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.IntravenousTableAdapter intravenousTableAdapter;
        private System.Windows.Forms.BindingSource painBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.PainTableAdapter painTableAdapter;
        private System.Windows.Forms.BindingSource skinIntegrityBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.SkinIntegrityTableAdapter skinIntegrityTableAdapter;
        private System.Windows.Forms.BindingSource gastrointestinalBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.GastrointestinalTableAdapter gastrointestinalTableAdapter;
        private System.Windows.Forms.BindingSource genitourinaryBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.GenitourinaryTableAdapter genitourinaryTableAdapter;
        private System.Windows.Forms.BindingSource cardiovascularBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.CardiovascularTableAdapter cardiovascularTableAdapter;
        private System.Windows.Forms.BindingSource respiratoryBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.RespiratoryTableAdapter respiratoryTableAdapter;
        private System.Windows.Forms.BindingSource neurologicalBindingSource;
        private Capstone_Project_FinalDataSetTableAdapters.NeurologicalTableAdapter neurologicalTableAdapter;
        private System.Windows.Forms.TabPage tabpageExtrimety;
        private System.Windows.Forms.BindingNavigator cast_Extremity_AssessmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton tsbBackCast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tsTxtCastPtID;
        private System.Windows.Forms.ToolStripButton tsBtnSearchCast;
        private System.Windows.Forms.TextBox dateTimeTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox8;
        private System.Windows.Forms.TextBox ifSwellingYesTextBox;
        private System.Windows.Forms.TextBox ifPainIncreaseYesTextBox;
        private System.Windows.Forms.TextBox ifDrainageYesTextBox;
        private System.Windows.Forms.Button btnCastSave;
        private System.Windows.Forms.Button btnCastNew;
        private System.Windows.Forms.ComboBox extremitySwellingComboBox;
        private System.Windows.Forms.ComboBox extremityPainIncreaseComboBox;
        private System.Windows.Forms.ComboBox extremitySensationComboBox;
        private System.Windows.Forms.ComboBox extremityTemperatureComboBox;
        private System.Windows.Forms.ComboBox extremityColorComboBox;
        private System.Windows.Forms.ComboBox drainageComboBox;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabpageIV;
        private System.Windows.Forms.BindingNavigator bindingNavigatorIV;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton btnBackIV;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsTxtIVPtID;
        private System.Windows.Forms.ToolStripButton tsBtnIVSearch;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IVdateTimeTextBox;
        private System.Windows.Forms.TextBox IVpatientIDTextBox;
        private System.Windows.Forms.TextBox ifPCAFentanylEpiduralOtherTextBox;
        private System.Windows.Forms.TextBox pCAMaxDosePerHourTextBox;
        private System.Windows.Forms.TextBox pCADemandDoseTextBox;
        private System.Windows.Forms.TextBox pCAContinuousDoseTextBox;
        private System.Windows.Forms.TextBox iVOverHrsTextBox;
        private System.Windows.Forms.TextBox iVFluidsDescriptionTextBox;
        private System.Windows.Forms.TextBox ifTypeLinePeripheralTextBox;
        private System.Windows.Forms.Button btnIVSave;
        private System.Windows.Forms.Button btnIVNew;
        private System.Windows.Forms.ComboBox ifPCAFentanylEpiduralComboBox;
        private System.Windows.Forms.ComboBox pCAFentanylComboBox;
        private System.Windows.Forms.ComboBox pCAComboBox;
        private System.Windows.Forms.ComboBox iVFluidsComboBox;
        private System.Windows.Forms.ComboBox insertionSiteComboBox;
        private System.Windows.Forms.ComboBox typeLineComboBox;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TabPage tabpageSkin;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton tsBtnBackSkin;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tsTxtPtIDSkin;
        private System.Windows.Forms.ToolStripButton tsBtnSearchSkin;
        private System.Windows.Forms.Button btnSaveSkin;
        private System.Windows.Forms.Button btnNewSkin;
        private System.Windows.Forms.TextBox dateTimeTextBoxSkin;
        private System.Windows.Forms.TextBox patientIDTextBoxSkin;
        private System.Windows.Forms.TextBox skinisDescriptionTextBox;
        private System.Windows.Forms.TextBox contusionEcchymosisLocationsTextBox;
        private System.Windows.Forms.TextBox contusionEcchymosisLengthTextBox;
        private System.Windows.Forms.TextBox signsofInflammationLocationTextBox;
        private System.Windows.Forms.ComboBox contusionEcchymosisComboBox;
        private System.Windows.Forms.ComboBox signsofInflammationComboBox;
        private System.Windows.Forms.ComboBox skinIsComboBox;
        private System.Windows.Forms.ComboBox skinColorComboBox;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.TabPage tabpageGastro;
        private System.Windows.Forms.TextBox dateTimeTextBoxGastro;
        private System.Windows.Forms.TextBox patientIDTextBoxGastro;
        private System.Windows.Forms.TextBox tubeFeedingAmountTextBox;
        private System.Windows.Forms.TextBox tubeFeedingTypeTextBox;
        private System.Windows.Forms.TextBox tubesPHAspirateTextBox;
        private System.Windows.Forms.TextBox lastBowelMovementOtherTextBox;
        private System.Windows.Forms.TextBox bowelMovementsOtherTextBox;
        private System.Windows.Forms.TextBox abdominalGirthTextBox;
        private System.Windows.Forms.Button btnNewGastro;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton tsBtnBackGastro;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tsTxtPtIDGastro;
        private System.Windows.Forms.ToolStripButton tsBtnSearchGastro;
        private System.Windows.Forms.Button btnSaveGastro;
        private System.Windows.Forms.ComboBox stomaStatusComboBox;
        private System.Windows.Forms.ComboBox stomaComboBox;
        private System.Windows.Forms.ComboBox tubeFeedingComboBox;
        private System.Windows.Forms.ComboBox insertionSiteComboBox1;
        private System.Windows.Forms.ComboBox tubesComboBox;
        private System.Windows.Forms.ComboBox bowelSoundsComboBox;
        private System.Windows.Forms.ComboBox nutritionalIntakeComboBox;
        private System.Windows.Forms.ComboBox continentComboBox;
        private System.Windows.Forms.ComboBox lastBowelMovementComboBox;
        private System.Windows.Forms.ComboBox bowelMovementsComboBox;
        private System.Windows.Forms.ComboBox abdomenComboBox;
        private System.Windows.Forms.ComboBox tongueComboBox;
        private System.Windows.Forms.ComboBox oralMucosaComboBox;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TabPage tabpageUrinary;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton tsBtnBack;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tsTxtPtIDGenit;
        private System.Windows.Forms.ToolStripButton tsBtnSearchGenit;
        private System.Windows.Forms.Button btnSaveGenit;
        private System.Windows.Forms.Button btnNewGenit;
        private System.Windows.Forms.TextBox dateTimeTextBoxGenit;
        private System.Windows.Forms.TextBox patientIDTextBoxGenit;
        private System.Windows.Forms.TextBox ifGenitaliaAbnormalitiesTextBox;
        private System.Windows.Forms.ComboBox insertionSiteComboBox2;
        private System.Windows.Forms.ComboBox urinaryCatheterComboBox;
        private System.Windows.Forms.ComboBox urinaryStentsComboBox;
        private System.Windows.Forms.ComboBox stomaStatusComboBox1;
        private System.Windows.Forms.ComboBox urostomyComboBox;
        private System.Windows.Forms.ComboBox urineCharComboBox;
        private System.Windows.Forms.ComboBox urineColorComboBox;
        private System.Windows.Forms.ComboBox urineAmountComboBox;
        private System.Windows.Forms.ComboBox continentGenComboBox;
        private System.Windows.Forms.ComboBox urinationAssessmentComboBox;
        private System.Windows.Forms.ComboBox genitaliaComboBox;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabpageRespiratory;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem7;
        private System.Windows.Forms.ToolStripButton tsBtnBackResp;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator21;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator22;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator23;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripTextBox tsTxtPtIDResp;
        private System.Windows.Forms.ToolStripButton tsBtnSearchResp;
        private System.Windows.Forms.Button btnNewResp;
        private System.Windows.Forms.Button btnSaveResp;
        private System.Windows.Forms.TextBox dateTimeTextBoxResp;
        private System.Windows.Forms.TextBox patientIDTextBoxResp;
        private System.Windows.Forms.TextBox respiratoryDyspneaTextBox;
        private System.Windows.Forms.TextBox ifOxygenCannulaTextBox;
        private System.Windows.Forms.TextBox ifColorOtherTextBox;
        private System.Windows.Forms.TextBox pulseOxWNLPatientTextBox;
        private System.Windows.Forms.ComboBox breathSoundsComboBox;
        private System.Windows.Forms.ComboBox respiratoryRhythmComboBox;
        private System.Windows.Forms.ComboBox respiratoryEffortComboBox;
        private System.Windows.Forms.ComboBox respiratoryRateComboBox;
        private System.Windows.Forms.ComboBox oxygenComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox consistencyComboBox;
        private System.Windows.Forms.ComboBox sputumComboBox;
        private System.Windows.Forms.ComboBox coughComboBox;
        private System.Windows.Forms.ComboBox pulseOxWNLComboBox;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabpageNeuro;
        private System.Windows.Forms.BindingNavigator bindingNavigator6;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem8;
        private System.Windows.Forms.ToolStripButton tsBtnBackNeuro;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem8;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator24;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem8;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator25;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem8;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator26;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripTextBox tsTxtPtIDNeuro;
        private System.Windows.Forms.ToolStripButton tsBtnSearchNeuro;
        private System.Windows.Forms.Button btnSaveNeuro;
        private System.Windows.Forms.Button btnNewNeuro;
        private System.Windows.Forms.TextBox dateTimeTextBoxNeuro;
        private System.Windows.Forms.TextBox patientIDTextBoxNeuro;
        private System.Windows.Forms.ComboBox locLLETRComboBox;
        private System.Windows.Forms.ComboBox locRLETRComboBox;
        private System.Windows.Forms.ComboBox locLueTRComboBox;
        private System.Windows.Forms.ComboBox locRueTRComboBox;
        private System.Windows.Forms.ComboBox locLHandTRComboBox;
        private System.Windows.Forms.ComboBox locRHandTRComboBox;
        private System.Windows.Forms.ComboBox locHeadNeckTRComboBox;
        private System.Windows.Forms.ComboBox locLLESEComboBox;
        private System.Windows.Forms.ComboBox locRLESEComboBox;
        private System.Windows.Forms.ComboBox locLueSEComboBox;
        private System.Windows.Forms.ComboBox locRueSEComboBox;
        private System.Windows.Forms.ComboBox locLHandSEComboBox;
        private System.Windows.Forms.ComboBox locRHandSEComboBox;
        private System.Windows.Forms.ComboBox locHeadNeckSEComboBox;
        private System.Windows.Forms.ComboBox locLLEMusStComboBox;
        private System.Windows.Forms.ComboBox locRLEMusStComboBox;
        private System.Windows.Forms.ComboBox locLueMusStComboBox;
        private System.Windows.Forms.ComboBox locRueMusStComboBox;
        private System.Windows.Forms.ComboBox locLHandMusStComboBox;
        private System.Windows.Forms.ComboBox locRHandMusStComboBox;
        private System.Windows.Forms.ComboBox locHeadNeckMusStComboBox;
        private System.Windows.Forms.ComboBox locLLEMTComboBox;
        private System.Windows.Forms.ComboBox locRLEMTComboBox;
        private System.Windows.Forms.ComboBox locLueMTComboBox;
        private System.Windows.Forms.ComboBox locRueMTComboBox;
        private System.Windows.Forms.ComboBox locLHandMTComboBox;
        private System.Windows.Forms.ComboBox locRHandMTComboBox;
        private System.Windows.Forms.ComboBox locHeadNeckMTComboBox;
        private System.Windows.Forms.ComboBox comSpeechComboBox;
        private System.Windows.Forms.CheckBox orientedToTimeCheckBox;
        private System.Windows.Forms.CheckBox orientedToPLCheckBox;
        private System.Windows.Forms.CheckBox orientedToPERCheckBox;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
    }
}