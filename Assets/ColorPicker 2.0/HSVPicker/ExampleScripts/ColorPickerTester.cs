using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace HSVPicker.Examples
{
    public class ColorPickerTester : MonoBehaviour 
    {

        public new List<Renderer> renderer = new List<Renderer>();
        public ColorPicker picker;

        public Color Color = Color.red;
        public bool SetColorOnStart = false;

	    // Use this for initialization
	    void Start () 
        {
            for (int i = 0; i < renderer.Count - 1; i++)
            {
                renderer[i].material.color = Color;
            }
        }
	
	    // Update is called once per frame
	    void Update () {
            for (int i = 0; i < renderer.Count - 1; i++)
            {
                picker.onValueChanged.AddListener(color =>
                {
                    renderer[i].material.color = color;
                    Color = color;
                });

                renderer[i].material.color = picker.CurrentColor;
                if (SetColorOnStart)
                {
                    picker.CurrentColor = Color;
                }
            }
        }
    }
}