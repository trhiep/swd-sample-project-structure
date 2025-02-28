﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleProjectStructure.Models.Entities;
using SampleProjectStructure.Utils.DBContext;

namespace SampleProjectStructure.Controllers.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly AccountContext _context;

        public IndexModel(AccountContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Accounts != null)
            {
                Account = await _context.Accounts.ToListAsync();
            }
        }
    }
}
