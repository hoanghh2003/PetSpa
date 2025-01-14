﻿namespace PetSpa.Models.DTO
{
    public class UpdateStaffRequestDTO
    {
        public Guid AccId { get; set; }

        public Guid StaffId { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; } = null!;
    }
}
