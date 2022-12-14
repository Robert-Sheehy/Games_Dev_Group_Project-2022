using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public Text TextBox;

    // Start is called before the first frame update
    void Start()
    {
        {
            //clear existing items
            var dropdown = transform.GetComponent<Dropdown>();

            dropdown.options.Clear();

            //Add test items
            List<string> items = new List<string>();
            items.Add("Item 1");
            items.Add("Item 2");

            //Fill dropdown with loopS
            foreach(var item in items)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });
            }

            DropdownItemSelected(dropdown);
            
            dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        }
    }

    private void DropdownItemSelected(Dropdown dropdown)
    {
       int index = dropdown.value;

       TextBox.text = dropdown.options[index].text;
    }
}
