using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollList : MonoBehaviour
{
    [SerializeField] private List<InformationData> _informationDataList = new List<InformationData>();
    [SerializeField] private int _nbElements = 10;

    private void Awake()
    {
        for (int i = 0; i < _nbElements; i++)
        {
            _informationDataList.Add(new InformationData($"ElementNumber{i}"));
        }
    }
}
