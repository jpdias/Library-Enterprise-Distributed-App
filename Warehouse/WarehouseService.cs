﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Warehouse
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WarehouseService" in both code and config file together.
    public class WarehouseService : IWarehouseService
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public void ReportToWarehouse(string message)
        {
            Debug.WriteLine(message);
        }
    }
}