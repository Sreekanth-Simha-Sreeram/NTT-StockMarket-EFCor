﻿
using StockMarketMVC.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace StockMarketMVC.BusinessLayer.Interface
{
    public interface IUserServices
    {
        User UpdateProfile(string UserName);
        Company SearchCompany(string CompanyName);
        Chart GetChart(Company company, string StockExchange, DateTime FromPeriod, DateTime ToPeriod);
        List<Company> FilterCompany(string CompanyName, string CompanyCode);
        List<Company> DisplayChart(List<Color> color);
        bool ExportDataFromChart(Chart chart);
        User GetUserById(int Id);
    }
}
