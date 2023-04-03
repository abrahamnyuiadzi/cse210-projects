namespace PasswordGenerator{


    public  partial class MainForm : Form 
    {

//
 public MainForm(){

    InitializeComponent();

 }
 public void trackBar1_Scroll (object sender ,EventArgs e )
 {
lblLength.Text = trackBar1_ScrollLength.Value.ToString();
 }

public void btnGenerate_Click (object sender,   EventArgs e  )
{
    GenerateConfig config =GetGenerateConfig();
    txtPassword.Text = PasswordGenHelper.GeneratePassword(config);
}
private GenerateConfig GetGenerateConfig()
{
  GenerateConfig config  =new GenerateConfig();
  config.length =trackBarLength.value ;
  config.IsDigitsCase =chklDigitsCase.Checked;
   config.IsLowerCase =chklLowerCase.Checked;
    config.IsUpperCase =chklDigitsCase.Checked;
     config.IsSymbolsCase =chklSymbolsCase.Checked;
     return config;
  {
    
  }
}

    }
}