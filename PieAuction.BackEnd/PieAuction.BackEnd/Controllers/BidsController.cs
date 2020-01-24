using PieAuction.BackEnd.Data_Access;
using PieAuction.BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PieAuction.BackEnd.Controllers
{
    public class BidsController : ApiController
    {
		
	[HttpPost]
	public Bid NewBid(Bid inBid)
	{
		var bidDao = new BidDao();
		return bidDao.NewBid(inBid);
	
	}
		

	}
}
