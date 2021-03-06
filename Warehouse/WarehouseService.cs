﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Threading;
using EnterpriseDistributedApplication;

namespace Warehouse
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WarehouseService" in both code and config file together.
    public class WarehouseService : IWarehouseService
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public void ReportToWarehouse(OrderBooks order)
        {
            MainWindow.AddToList(order);
            Record rec = new Record();
            rec.ProcessPackage(order);
        }
    }
}
