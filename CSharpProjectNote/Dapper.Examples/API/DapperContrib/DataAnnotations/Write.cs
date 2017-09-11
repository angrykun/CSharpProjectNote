﻿// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.DapperContrib.DataAnnotations
{
    public partial class Write : Form
    {
        public Write()
        {
            InitializeComponent();
        }

        private void Get(object sender, EventArgs e)
        {
            My.Database.Reset();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.Get<InvoiceContrib>(1);

                // The FakeProperty is null

                My.Result.Show(invoice);
            }
        }
    }
}