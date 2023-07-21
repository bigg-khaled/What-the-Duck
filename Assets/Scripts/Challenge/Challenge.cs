using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Challenge : ScriptableObject
{

    
    public enum ChallengeType
    {
        BACKFLIP,
        REACH_HEIGHT,
        HIT_TARGET,
        REACH_SPEED,
    };

    public enum ChallnegeStatus
    {
        ON_GOING,
        COMPLETED,
        FAILED,
    };

    //pick random challenge type from enum
    private ChallengeType challengeType;
    private ChallnegeStatus challengeStatus;
    public int amount;
    public float timeLimit;
    public GameObject target;
    public int score;
    public int scoreMultiplier;
    
    //get challenge type
    public ChallengeType GetChallengeType()
    {
        return challengeType;
    }
    
    public void CompleteChallenge()
    {
        challengeStatus = ChallnegeStatus.COMPLETED;
    }
    
    public void FailChallenge()
    {
        challengeStatus = ChallnegeStatus.FAILED;
    }
    
    public void StartChallenge()
    {
        challengeStatus = ChallnegeStatus.ON_GOING;
        
        //preform challenge
        switch (challengeType)
        {
            case ChallengeType.BACKFLIP:
                //check if player has done a backflip
                break;
            case ChallengeType.REACH_HEIGHT:
                //check if player has reached a certain height
                break;
            case ChallengeType.HIT_TARGET:
                //check if player has hit a target
                break;
            case ChallengeType.REACH_SPEED:
                //check if player has reached a certain speed
                break;
        }
        
    }
    
    //create random challenge
    public void CreateChallenge()
    {
        // get a random challenge from the list of challenges and assign it to the currentChallenge variable.
        // set the timeLeft variable to the timeLimit of the currentChallenge.
        // set the isChallengeActive variable to true.
        // set the isChallengeCompleted variable to false.
        challengeType = (ChallengeType)UnityEngine.Random.Range(0, 4);
        switch (challengeType)
        {
            case ChallengeType.BACKFLIP:
                amount = UnityEngine.Random.Range(1, 4);
                timeLimit = 5;
                score = 100;
                scoreMultiplier = 1;
                break;
            case ChallengeType.REACH_HEIGHT:
                amount = UnityEngine.Random.Range(1, 4);
                timeLimit = 5;
                score = 100;
                scoreMultiplier = 1;
                break;
            case ChallengeType.HIT_TARGET:
                amount = UnityEngine.Random.Range(1, 4);
                timeLimit = 5;
                score = 100;
                scoreMultiplier = 1;
                break;
            case ChallengeType.REACH_SPEED:
                amount = UnityEngine.Random.Range(1, 4);
                timeLimit = 5;
                score = 100;
                scoreMultiplier = 1;
                break;
        }
    }
    
}
