using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{

    [SerializeField] Camera main_camera, front_camera;
    [SerializeField] TMPro.TMP_Text text_name, text_sound;
    [SerializeField] Slider slider;
    [SerializeField] GameObject selected, main_scene;
    private Vector3 vector = new Vector3(1f, 1f, 1f);
    public static MainManager Instance;
    private AudioSource audio_reference;
    private int code = 0;
    enum Animals {DogRe , FrogRe, CatRe, CowRe};
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
        
        front_camera.gameObject.SetActive(false);
        selected.SetActive(false);
        
    }

    public void ChangeCamera(Vector3 object_position, string Name, string Sound, AudioSource _audio, int code_animal)
    {
        
        if(main_camera.isActiveAndEnabled)
        {
            code = code_animal;
            audio_reference = _audio;
            float _y = front_camera.gameObject.transform.position.y;
            Vector3 vector = new Vector3(object_position.x,  _y ,front_camera.gameObject.transform.position.z);
            AnimalCamera(vector,Sound, Name);
        }
        else
        {
            //PlayerPrefs.SetInt("UnitySelectMonitor", 0);
            front_camera.gameObject.SetActive(false);
            main_camera.gameObject.SetActive(true);

        }
    }
    public void MainCamera()
    {
        audio_reference.enabled = false;
        selected.SetActive(false);
        main_scene.SetActive(true);
        front_camera.gameObject.SetActive(false);
        main_camera.gameObject.SetActive(true);
    }
    public void AnimalCamera(Vector3 vector, string sound,string text)
    {
        slider.value = 1;
        audio_reference.enabled = true;
        text_name.text = text;
        text_sound.text = sound;
        front_camera.transform.position = vector;
        main_camera.gameObject.SetActive(false);
        front_camera.gameObject.SetActive(true);
        main_scene.SetActive(false);
        selected.SetActive(true);
    }
    public void Sound()
    {
        audio_reference.Play(0);
    }
    public void ModifiedSize()
    {
        string name = text_name.text;
        switch(code)
        {
            case ((int)Animals.DogRe):
                Dog.Instance.Size = slider.value * 1;
                Dog.Instance.gameObject.transform.localScale = (vector * Dog.Instance.Size);
                break;
            case ((int)Animals.FrogRe):
                Frog.Instance.Size = slider.value * 1;
                Frog.Instance.gameObject.transform.localScale = (vector * Frog.Instance.Size);
                //Frog.Instance.gameObject.transform.localScale *= (slider.value / 2);
                break;
            case ((int)Animals.CatRe):
                Cat.Instance.Size = slider.value * 1;
                Cat.Instance.gameObject.transform.localScale = (vector * Cat.Instance.Size);
                //Cat.Instance.gameObject.transform.localScale *= (slider.value / 2);
                break;
            case ((int)Animals.CowRe):
                Cow.Instance.Size = (slider.value * 1) ;
                Cow.Instance.gameObject.transform.localScale = (vector * Cow.Instance.Size);
                //Cow.Instance.gameObject.transform.localScale *= (slider.value / 2);
                break;
            default:
                break;

        }
        //size_dictionary[text_name.text] *= (slider.value / 2);
        //Debug.Log(size_dictionary[text_name.text]);
        //Debug.Log(slider.value / 2);

    }
}
