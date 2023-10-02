using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_1_1 {
    public partial class MainPage:ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private async void acction(object sender,EventArgs e){
            if(sender is Button button_clicked){
                var button_text=button_clicked.Text;

                if(validation()){
                    if(button_text=="Division"){
                        double number;

                        if(double.TryParse(txt_num2.Text,out number)){
                            if(number>0.0){
                                calculate(button_text);
                            }else{
                                DisplayAlert("Error","No se puede dividir entre 0","OK");
                            }
                            
                        }else{
                            DisplayAlert("Error","No se puede dividir entre 0","OK");
                        }
                        
                    }else{
                        calculate(button_text);
                    }
                }
            }
        }

        private void calculate(string button_text) {
            Mathematical_operations mathematical_operation = new Mathematical_operations(Convert.ToDouble(txt_num1.Text),Convert.ToDouble(txt_num2.Text),button_text);
            Navigation.PushAsync(new Page_result());
        }

        private bool validation(){
            var regex=new Regex(@"^(?!-?$)-?\d*(?:\.\d+)?$");

            if(string.IsNullOrWhiteSpace(txt_num1.Text) || string.IsNullOrWhiteSpace(txt_num2.Text)) {
                DisplayAlert("Advertencia","No dejar campos vacios","OK");
                return false;
            }

            if(!regex.IsMatch(txt_num1.Text) || !regex.IsMatch(txt_num2.Text)) {
                DisplayAlert("Advertencia","Revisa bien el numero que ingresastes","OK");
                return false;
            }

            return true;
        }
    }
}