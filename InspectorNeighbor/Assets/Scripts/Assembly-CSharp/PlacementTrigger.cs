using System.Collections.Generic;
using UnityEngine;

public class PlacementTrigger : Frobbable
{
	public List<Placeable> PlacementObjects;
	public Placeable InitialPlacedObject;
	public ConfigurableJoint ConnectionJoint;
}
