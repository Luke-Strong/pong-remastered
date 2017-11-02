using UnityEngine;
using System.Collections;

// The Hero class has three responsibilities:
// - OnGUI provides the actions the player is able to perform.
// - Tracks the player's inventory/status.
// - Communicates with the AchievementManager to track progress.

public class Hero : MonoBehaviour
{
    public AchievementManager AchievementManager;

    private bool inStealthMode = false;
    private int currentLevel = 0;
    private int numRedPotions = 0;
    private int numBluePotions = 0;
    private int numGreenPotions = 0;
    
	void Start()
    {
        LevelUp();
	}

    private void LevelUp()
    {
        currentLevel++;
//        AchievementManager.AddProgressToAchievement("Junior Hero", 1.0f);
        AchievementManager.AddProgressToAchievement("Experienced Hero", 1.0f);
		AchievementManager.AddProgressToAchievement("Pong Enthusiast", (float)ZPlayerPrefs.GetInt("High Score"));
		AchievementManager.AddProgressToAchievement("Pong Diehard", (float)ZPlayerPrefs.GetInt("High Score"));
		AchievementManager.AddProgressToAchievement("Pong Aficionado", (float)ZPlayerPrefs.GetInt("High Score"));
		AchievementManager.AddProgressToAchievement("Pong Expert", (float)ZPlayerPrefs.GetInt("High Score"));
		AchievementManager.AddProgressToAchievement("Pong Master", (float)ZPlayerPrefs.GetInt("High Score"));

		AchievementManager.AddProgressToAchievement("Seeing Red", (float)ZPlayerPrefs.GetInt("Seeing Red"));

    }
	
	void Update()
    {
        if (inStealthMode)
        {
			// If the player is in stealth mode then tick up the time spent towards the Invisible Man achievement.
            AchievementManager.AddProgressToAchievement("The Invisible Man", Time.deltaTime);
        }
	}

    private void PotionQuantitiesChanged()
    {
        AchievementManager.SetProgressToAchievement("Potion Hoarder", numRedPotions + numBluePotions + numGreenPotions);
        if (numRedPotions > 0 && numBluePotions > 0 && numGreenPotions > 0)
        {
			// The player has collected one of each potion type.
            AchievementManager.SetProgressToAchievement("Potion Collector", 1.0f);
        }
    }

    private void BuyPotion(ref int potion)
    {
        potion++;
        AchievementManager.SetProgressToAchievement("Potion Owner", 1.0f);
        PotionQuantitiesChanged();
    }

    private void DrinkPotion(ref int potion)
    {
        potion--;
        AchievementManager.AddProgressToAchievement("Town Drunk", 1.0f);
        PotionQuantitiesChanged();
    }

}