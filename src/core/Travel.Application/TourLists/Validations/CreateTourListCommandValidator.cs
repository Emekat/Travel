﻿using FluentValidation;
using Travel.Application.Common.Interfaces;
using Travel.Application.TourLists.CommandsAndHandlers;

namespace Travel.Application.TourLists.Validations
{
    public class CreateTourListCommandValidator : AbstractValidator<CreateTourListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateTourListCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(200).WithMessage("City must not exceed 90 characters.");

            RuleFor(v => v.Country)
                .NotEmpty().WithMessage("Country is required")
                .MaximumLength(200).WithMessage("Country must not exceed 60 characters.");

            RuleFor(v => v.About)
                .NotEmpty().WithMessage("About is required");
        }
    }
}