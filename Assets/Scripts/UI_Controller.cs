using UnityEngine;
using UnityEngine.UIElements;

public class UI_Controller : MonoBehaviour
{
    public UIDocument UIDocument;

    private Label energyLabel, coinsLabel;
    private Button btnLessEnergy, btnMoreEnergy, btnLessCoins, btnMoreCoins;
    private int energy, coins;

    private void OnEnable()
    {
        VisualElement root = UIDocument.rootVisualElement;

        energyLabel = root.Q<Label>("energyLabel");
        coinsLabel = root.Q<Label>("coinsLabel");

        energy = int.Parse(energyLabel.text);
        coins = int.Parse(coinsLabel.text);

        btnLessEnergy = root.Q<Button>("btnLessEnergy");
        btnMoreEnergy = root.Q<Button>("btnMoreEnergy");
        btnLessCoins = root.Q<Button>("btnLessCoins");
        btnMoreCoins = root.Q<Button>("btnMoreCoins");

        if(btnLessEnergy == null || btnMoreEnergy == null || btnLessCoins == null || btnMoreCoins == null)
        {
            Debug.Log("No se pudo acceder a los botones");
        }
        else
        {
            btnLessEnergy.clicked += LessEnergy;
            btnMoreEnergy.clicked += MoreEnergy;
            btnLessCoins.clicked += LessCoins;
            btnMoreCoins.clicked += MoreCoins;
        }    
    }

    private void OnDisable()
    {
        if (btnLessEnergy == null || btnMoreEnergy == null || btnLessCoins == null || btnMoreCoins == null)
        {
            Debug.Log("No se pudo acceder a los botones");
        }
        else
        {
            btnLessEnergy.clicked += LessEnergy;
            btnMoreEnergy.clicked += MoreEnergy;
            btnLessCoins.clicked += LessCoins;
            btnMoreCoins.clicked += MoreCoins;
        }
    }

    private void LessEnergy()
    {
        energy--;
        energyLabel.text = energy.ToString();
    }

    private void MoreEnergy()
    {
        energy++;
        energyLabel.text = energy.ToString();
    }

    private void LessCoins()
    {
        coins--;
        coinsLabel.text = coins.ToString();
    }

    private void MoreCoins()
    {
        coins++;
        coinsLabel.text = coins.ToString();
    }

}
