using UnityEngine;

internal sealed class DialogManager : MonoBehaviour
{
    private DialogNode currentNode; //текущая активная часть диалога


    public void StartDialog(DialogNode startNode)  //стартует диалог с указанной части
    {
        if (startNode.CanShowNode())
        {
            currentNode = startNode;
            ShowNode(currentNode);
        }
    }

    private void ShowNode(DialogNode node) //показывает текст диалога и опции
    {
        Debug.Log("Showing node " + node.Text);

        foreach(var option in node.nodes)
        {
            Debug.Log("Variants:" + option.Text);
        }
    }

    public void SelectOption(DialogOption option) //обрабатывает выбранный вариант ответа
    {
        option.Select();
        currentNode.CompleteNode();
    }
}
