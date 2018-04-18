using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WSClient.Shell;
using WSClient.Shell_Prod;

namespace WSClient
{

    

    class Program
    {
      
        static void Main(string[] args)
        {
            PartnerCardSoapClient deneme = new PartnerCardSoapClient("PartnerCardSoap121");
           // deneme.ClientCredentials.UserName.UserName = "TEST";
          //  deneme.ClientCredentials.UserName.Password = "1q2w3e4r5T";
            Console.WriteLine(deneme.PCARD_CUSTOMER_GET_DETAIL("0012635284", "TEST", "1q2w3e4r5T").crd);
            Console.WriteLine(deneme.PCARD_CARD_GET_DETAIL("0012582082", "TRANSAY", "Trn1453?", "1300173522").cardCredit.dfl_amt);
            Console.WriteLine(deneme.PCARD_CUSTOMER_GET_DETAIL("0012582082", "TRANSAY", "Trn1453?").crd.Value);
            Console.ReadKey();
        }
    }

    
}
