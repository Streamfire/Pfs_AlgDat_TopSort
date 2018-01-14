using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alg_naiv : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void AlgStart() {
        LinkedList<GameObject> Nodes = GameObject.FindGameObjectWithTag("MainController").GetComponent<Controller>().Nodes;
        LinkedList<ConditionData> Cond = GameObject.FindGameObjectWithTag("MainController").GetComponent<Controller>().Cond;

        //sortierte Liste
        LinkedList<GameObject> sortedList = new LinkedList<GameObject>();

        //-----------Initialisierung der Knoten / Vergabe der eing. Kanten-------- 

        //ToDo: Abfrage erstellen, ob Überhaupt Conditions und Knoten enthalten sind
        LinkedListNode<ConditionData> currentCondition = Cond.First;

        while (currentCondition.Next != null)
        {
            currentCondition.Value.NodeB.GetComponent<NodeController>()._conditionNumberIn++;
            currentCondition = currentCondition.Next;
        }


        //-----------Algorithmus zur Erstellung einer topologischen Sortierung (naiv)-----------

        while (Nodes.Count != 0)
        {
            //derzeitiger Knoten
            LinkedListNode<GameObject> currentNode = Nodes.First;
            
            //Knoten nach eingehenden Kanten == 0 durchsuchen
            while (currentNode != null && currentNode.Value.GetComponent<NodeController>()._conditionNumberIn != 0)
            {
                currentNode = currentNode.Next;     
            }

            //Falls ein Knoten mit keiner eingehenden Kante gefunden wurde
            if (currentNode != null)
            {
                //Knoten hinzufügen
                sortedList.AddLast(currentNode);


                //Kante(n) entfernen
                //Zeiger auf Anfang von Liste setzen
                currentCondition = Cond.First;
                
                //Alle Kanten durchgehen
                while (currentCondition != null)
                {
                    //wenn eine Kante mit dem derzeitigen Knoten in Beziehung steht -> Kante entfernen
                    if (currentCondition.Value.NodeA == currentNode.Value)
                    {
                        //Anz. eingehender Kanten von Knoten dekrementieren
                        currentCondition.Value.NodeB.GetComponent<NodeController>()._conditionNumberIn--;

                        //Kante entfernen
                        //Nächste Kante zwischenspeichern
                        LinkedListNode<ConditionData> tempCondition = currentCondition.Next;

                        //Kante aus Liste löschen
                        Cond.Remove(currentCondition);

                        //currentCondtion aus temp holen
                        currentCondition = tempCondition;

                    }
                    //sonst gleich nächste Kante auswählen
                    else
                    {
                        currentCondition = currentCondition.Next;
                    }
                }

            }
            //kein Knoten mit keiner eingehenden Kante existiert -> Fehler ausgeben, Graph nicht azyklisch
            else
            {

            }
        }
        
    }
}
