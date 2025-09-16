using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    internal class HelloWorld3 : MonoBehaviour
    {
        void Start()
        {

            // Find and
            // interact with HelloWorld component
            HelloWorld helloWorldScript = FindFirstObjectByType<HelloWorld>();

            if (helloWorldScript != null)
            {
                Debug.Log("HelloWorld component found!");
            }
            else
            {
                Debug.Log("HelloWorld component not found.");
            }
        }
    }
}
