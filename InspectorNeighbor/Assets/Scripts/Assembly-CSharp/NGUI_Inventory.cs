using UnityEngine;
using System.Collections.Generic;

public class NGUI_Inventory : MonoBehaviour
{
	public InputContext InventoryContext;
	public InputContext JournalContext;
	public InputContext MapContext;
	public InputContext WASDInventoryContext;
	public string JournalPath;
	public string KeyPath;
	public string NewItemText;
	public float NewItemDisplayTime;
	public List<KeyItem> StartItems;
	public int InventorySize;
	public int JournalColumns;
	public UIAtlas InventoryContentAtlas;
	public UIPanel InventoryPanel;
	public Camera InventoryCamera;
	public UILabel DescriptionLabel;
	public UISprite DisplaySprite;
	public UIPanel KeysPanel;
	public UIPanel JournalsPanel;
	public UIPanel MapPanel;
	public string BlankBoxSprite;
	public GameObject GridItemPrefab;
	public GameObject JournalListItemPrefab;
	public UIScrollBar JournalListScrollBar;
	public int JournalScrollBarMinimum;
	public UISprite ItemsHighlight;
	public UISprite JournalsHighlight;
	public UISprite MapHighlight;
	public UILabel LBButton;
	public UILabel RBButton;
	public List<JournalListItem> UIJournals;
}
