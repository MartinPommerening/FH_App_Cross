using System;
using System.Collections.Generic;

namespace FHErfurtAppCross
{
	public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
			this.Add (new MenuItem () { 
				Title = "Contracts", 
				//IconSource = "contracts.png", 
				TargetType = typeof(NewsPage)
			});

			this.Add (new MenuItem () { 
				Title = "Leads", 
				//IconSource = "Lead.png", 
				TargetType = typeof(PersonPage)
			});

			this.Add (new MenuItem () { 
				Title = "Accounts", 
				//IconSource = "Accounts.png", 
				//TargetType = typeof(AccountsPage)
			});

			this.Add (new MenuItem () {
				Title = "Opportunities",
				//IconSource = "Opportunity.png",
				//TargetType = typeof(OpportunitiesPage)
			});
		}
	}
}

