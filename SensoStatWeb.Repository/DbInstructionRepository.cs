using System;
using SensoStatWeb.Models.Entities;
using SensoStatWeb.Repository.Interfaces;

namespace SensoStatWeb.Repository
{
	public class DbInstructionRepository : IInstructionRepository
	{
        private readonly SensoStatDbContext _context;
        public DbInstructionRepository(SensoStatDbContext context)
        {
            _context = context;
        }

        public List<Instruction> GetAllInstructions()
        {
            return _context.Instructions.ToList();
        }

        public async Task<Instruction>? CreateInstruction(Instruction instruction)
        {
            _context.Instructions.Add(instruction);
            _context.SaveChanges();

            var result = _context.Instructions.Where(s => s.Equals(instruction));

            if (result == null)
            {
                return null;
            }
            else
            {
                return result.FirstOrDefault();
            }
        }

        public async Task<bool>? DeleteInstruction(int id)
        {
            var deletedInstruction = _context.Instructions.Where(instruction => instruction.Id == id).FirstOrDefault();

            _context.Instructions.Remove(deletedInstruction);
            _context.SaveChanges();

            var result = _context.Instructions.Where(s => s.Equals(deletedInstruction));

            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

