using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string Final; // Nome da cena para carregar quando o jogador entra na porta

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica se o objeto que colidiu Ã© o jogador
        {
            SceneManager.LoadScene(Final); // Carrega a cena especificada
        }
    }
}