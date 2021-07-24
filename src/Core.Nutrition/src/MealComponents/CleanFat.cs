﻿using Application.Core.Common.Enums;
using Application.Core.Nutrition.Attributes;
using Application.Core.Nutrition.Constants;
using Application.Core.Nutrition.MealComponents.Base;

namespace Application.Core.Nutrition.MealComponents
{
    [CollectionName(MealCollectionNames.CleanFats)]
    internal sealed class CleanFat : MealComponent
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CleanFat" /> with macronutrient.
        /// </summary>
        public CleanFat() : base(MacroNutrient.Fat)
        {
        }
    }
}