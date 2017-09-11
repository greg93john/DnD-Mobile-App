using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*[Tooltip()]*/
public enum CharacterClass { }
public enum CharacterRace { }

[RequireComponent(typeof(CharacterHealth))]
[RequireComponent(typeof(CharacterOffense))]
public class CharacterObject : MonoBehaviour {

    [Header("Character Name")]
    public string characterName;
    [Header("Character Class")]
    public CharacterClass myClass;
    public CharacterRace myRace;
    [Header("Character Stats")]
    public int characterLevel;
    public int strength, dexterity, constitution, intelligence, wisdom, charisma;

    [Header("ect.")]
    public float expThreshold = 100f;
    public string[] abilityNames;

    private CharacterHealth myHealth;
    private CharacterOffense myOffense;

    [Range(-5,10)]private int abilityModifier;
    private float currentExperiencePoints;


    // Methods for character leveling.

    public void GainExperience(float exp) {
        currentExperiencePoints += exp;
        CalculateExp();
    } private void CalculateExp() {
        if (currentExperiencePoints >= expThreshold) {
            IncrementCharacterLevel();
            currentExperiencePoints -= expThreshold;
            if (currentExperiencePoints > expThreshold) {
                CalculateExp();
            }
        }
    } public void IncrementCharacterLevel() {
        characterLevel++;
    }

    public void SetCharacterLevel(int setVal) {
        characterLevel = setVal;
    }
}
