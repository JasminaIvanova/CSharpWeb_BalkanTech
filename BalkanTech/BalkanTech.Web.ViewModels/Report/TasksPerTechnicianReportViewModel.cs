﻿using BalkanTech.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalkanTech.Web.ViewModels.Report
{
    public class TasksPerTechnicianReportViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public string Name { get; set; }
        public List<MaintananceTask> ToBeCompletedTasks { get; set; } = new List<MaintananceTask>();
    }
}
