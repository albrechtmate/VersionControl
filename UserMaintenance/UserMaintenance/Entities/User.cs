﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName;
        public string LastName;
        public string FullName { get; set; }

        // Ugyanaz a FullName property kompaktabb formában is írható
        /*
        public string FullName
            => string.Format(
                "{0} {1}",
                LastName,
                FirstName);
        */
    }
}
