using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana =100
    public TMP_Text manaText;
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }
}
void Update()
{
    manaText.text = "Mana: " + mana;
    Spell()
}
void Spell()
{
    if (Keyboard.current.fKey.wasPressedThisFrame)
    {
        animator.SetBool("spell", true);
    }
    else
    {
        animator.SetBool("spell", false);
    }
}