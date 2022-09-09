using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infrestructure.Data;

namespace Infrestructure.Repositories
{
    public class ContactRepository : IContactsRepository
    {

        private readonly ApiContext _context;
        public ContactRepository(ApiContext context)
        {
            this._context = context;
        }

        public async Task<bool> DeleteContact(int id)
        {
            var current = await GetContact(id);
            _context.contact.Remove(current);
            var rowsDelete = await _context.SaveChangesAsync();
            return rowsDelete > 0;
        }

        public async Task<Contact> GetContact(int id)
        {
           return await _context.contact.SingleOrDefaultAsync(animal => animal.Id == id)
            ?? new Contact();
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _context.contact.ToListAsync();
        }
    }
}