using UnityEngine;

internal sealed class DialogManager : MonoBehaviour
{
    private DialogNode currentNode;
    public void StartDialog(DialogNode startNode) 
    {
        currentNode = startNode;
        ShowNode(currentNode);
    }
    private void ShowNode(DialogNode node)
    {
        Debug.Log("’ыхых " + node.text);

        foreach(var option in node.nodes)
        {
            Debug.Log("ќпции:" + option.text);
        }
    }
    public void SelectOption(DialogOption option) 
    {
        option.Select();
        currentNode.CompleteNode();
    }
}
