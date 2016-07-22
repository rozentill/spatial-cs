﻿// Nick Olenz

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecipesDB : MonoBehaviour
{
	// Stores all recipes which are currently unlocked and will appear
	// in the recipes interface.
	public static List<Recipe> unlockedRecipes = new List<Recipe>();

	// Delcare all recipes below.
	public static Recipe TestRecipe = new Recipe("Test Recipe", 
												 "This is a test.",
												 new string[] { "Cube" },
												 new int[] { 5 } );

	public static Recipe TestRecipe2 = new Recipe("Test Recipe 2",
												  "Another test.",
												  new string[] { "Cube" },
												  new int[] { 2 } );

	public static Recipe RocketBoots = new Recipe("Rocket Boots",
												  "construction",
												  new string[] { "Rocket Boots Sole", "Rocket Boots Toe Sole", "Rocket Boots Toe", "Rocket Boots Trim", "Rocket Boots Calf", "Rocket Boots Body" },
												  new int[] { 1, 1, 1, 1, 1, 1 });

	public static Recipe Sledgehammer = new Recipe("Sledgehammer",
												   "axe",
												   new string[] { "Sledgehammer Bottom Point", "Sledgehammer Haft", "Sledgehammer Head", "Sledgehammer Shaft", "Sledgehammer Top Point", "Sledgehammer Trapezoid" },
												   new int[] { 1, 1, 1, 1, 1, 1 });
}
