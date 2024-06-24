using System;
using System.Collections.Generic;
using System.Text;

namespace TrainMetasolAbp.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
