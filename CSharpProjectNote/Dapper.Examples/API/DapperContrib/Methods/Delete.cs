﻿// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.DapperContrib.Methods
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Single(object sender, EventArgs e)
        {
            My.Database.Reset(includeDetail: false, includeItems: false);

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var isSuccess = connection.Delete(new InvoiceContrib {InvoiceID = 1});

                My.Result.Show(isSuccess);
            }
        }

        private void Many(object sender, EventArgs e)
        {
            My.Database.Reset(includeDetail: false, includeItems: false);

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var list = new List<InvoiceContrib>
                {
                    new InvoiceContrib {InvoiceID = 1},
                    new InvoiceContrib {InvoiceID = 2},
                    new InvoiceContrib {InvoiceID = 3}
                };

                var isSuccess = connection.Delete(list);

                My.Result.Show(isSuccess);
            }
        }
    }
}