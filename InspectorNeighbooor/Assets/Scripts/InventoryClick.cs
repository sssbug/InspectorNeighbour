using UnityEngine.EventSystems;
using UnityEngine;



namespace Hel.Items.Hotbars
{




    public class InventoryClick : ItemDragHandler
    {

        private Variables variables;


        private void Start()
        {

            variables = GameObject.Find("VariablesController").GetComponent<Variables>();

        }
        public override void OnPointRightClick(PointerEventData eventData)
        {
            base.OnPointRightClick(eventData);

            if (eventData.button == PointerEventData.InputButton.Right)
            {
                variables.pivot.SetActive(true);
                variables.pivot.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
        }
    }
}