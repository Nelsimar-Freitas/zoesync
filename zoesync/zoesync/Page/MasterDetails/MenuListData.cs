using System.Collections.Generic;

namespace zoesync.Page.MasterDetails
{
    public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
			this.Add (new MenuItem () { 
				Title = "Agenda", 
				IconSource = "contacts.png", 
				TargetType = typeof(CadastroHorario)
			});

			this.Add (new MenuItem () { 
				Title = "Hor�rios Livres", 
				IconSource = "leads.png", 
				TargetType = typeof(CadastroHorario)
			});

			this.Add (new MenuItem () { 
				Title = "Hist�rico", 
				IconSource = "accounts.png", 
				TargetType = typeof(HomePage)
			});


            this.Add(new MenuItem()
            {
                Title = "Cl�nica XYZ",
                IconSource = "opportunities.png",
                TargetType = typeof(CadastroLocal)
            });

            this.Add(new MenuItem()
            {
                Title = "Trocar Local",
                IconSource = "opportunities.png",
                TargetType = typeof(CadastroLocal)
            });

            this.Add (new MenuItem () {
				Title = "Sair",
				IconSource = "opportunities.png",
				TargetType = typeof(LoginPage)
			});
		}
	}

}

