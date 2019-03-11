using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityApplication.Controllers
{
    public class SecretController : Controller
    {
		//this attribute [Authorize] will:
		//-restrict access to a specific action, to only users that are authenticated against the site
		//without any parameters, this attribute will make sure the identity of the user is known and 
		//they are not an anonymous user
		//it will do this by redireting the user to an area of the site, where an identity does not need
		//to be known, for example the login page
		//without this attribute, typing in the /secret/secret once the application loads and there is no user logged in
		//will allow the user to view the SecretController
		//with the authorized attribute, it redirects the user to the login page and once logged in
		//redirects me back to the /secret/secret page, I was trying to access, before I got re-directed
		//very cool feature, def want to explore this more
		[Authorize]
		//this particular action should be protected
		public ContentResult Secret()
		{
			return Content("This is a secret...");
		}
		//overt means out in the open, i.e. not a secret lol
		public ContentResult Overt()
		{
			return Content("This is not a secret! Hooray!");
		}
    }
}