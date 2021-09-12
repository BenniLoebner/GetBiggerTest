using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{ 
    const int GAMEOVER_SCENE_INDEX = 3;
    const int MENU_SCENE_INDEX = 0;
    const int LEVELS_SCENE_INDEX = 1;
    const int WINSCREEN_SCENE_INDEX = 4;

    SelectedScene mySelectedScene;

    void Start()
    {
        mySelectedScene = FindObjectOfType<SelectedScene>();
    }
    public void LoadGameModeScene()
    {
        StartCoroutine(WaitforSoundGameMode());
    }

    IEnumerator WaitforSoundGameMode()
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("GameModes");
    }

    public void LoadUpgrades1()
    {
        StartCoroutine(WaitForSoundUpgrades1());
    }
    IEnumerator WaitForSoundUpgrades1()
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Upgrades1");
    }
    public void LoadUpgrades2()
    {
        StartCoroutine(WaitForSoundUpgrades2());
    }
    IEnumerator WaitForSoundUpgrades2()
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Upgrades2");
    }

    public void LoadRestartScene()
    {
        StartCoroutine(WaitforSoundRestart());
    }

    IEnumerator WaitforSoundRestart()
    {
        int currentSceneIndex = mySelectedScene.GetLastScene();
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextLevel()
    {
        StartCoroutine(WaitForSoundNextlevel());
    }

    IEnumerator WaitForSoundNextlevel()
    {
        int currentSceneIndex = mySelectedScene.GetLastScene();
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadMainMenu()
    {
        StartCoroutine(WaitForSoundMainMenu());
    }

    IEnumerator WaitForSoundMainMenu()
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Menu");
    }

    public void LoadLevels()
    {
        StartCoroutine(WaitForSoundLevels());
    }

    IEnumerator WaitForSoundLevels()
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Levels");
    }

    public void LoadPlayerSelectionScene()
    {
        StartCoroutine(WaitForSoundPlayerSelection());
    }

    IEnumerator WaitForSoundPlayerSelection() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("PlayerSelection");
    }

    public void CallLevelLoad(string level)
    {
        StartCoroutine(LoadLevel(level));
    }

    IEnumerator LoadLevel(string level) 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene(level);
    }

   /*  public void LoadLevel2()
    {
        StartCoroutine(WaitForSound2());
    }

    IEnumerator WaitForSound2() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevel3()
    {
        StartCoroutine(WaitForSound3());
    }

    IEnumerator WaitForSound3() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level3");
    }

    public void LoadLevel4()
    {
        StartCoroutine(WaitForSound4());
    }

    IEnumerator WaitForSound4() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level4");
    }

    public void LoadLevel5()
    {
        StartCoroutine(WaitForSound5());
    }

    IEnumerator WaitForSound5() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level5");
    }

    public void LoadLevel6()
    {
        StartCoroutine(WaitForSound6());
    }

    IEnumerator WaitForSound6() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level6");
    }

    public void LoadLevel7()
    {
        StartCoroutine(WaitForSound7());
    }

    IEnumerator WaitForSound7() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level7");
    }

    public void LoadLevel8()
    {
        StartCoroutine(WaitForSound8());
    }

    IEnumerator WaitForSound8() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level8");
    }

    public void LoadLevel9()
    {
        StartCoroutine(WaitForSound9());
    }

    IEnumerator WaitForSound9() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Level9");
    }

    public void LoadMazeLevels()
    {
        StartCoroutine(WaitForSoundMazeLevels());
    }

    IEnumerator WaitForSoundMazeLevels() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("MazeLevels");
    }

    public void LoadMaze1()
    {
        StartCoroutine(WaitForSoundMaze1());
    }

    IEnumerator WaitForSoundMaze1() 
    {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Maze1");
    }
 */
}
