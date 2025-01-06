using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Settings
{
    #region UNITS
    // 유닛 크기 설정
    public const float pixelsPerUnit = 16f; // 유닛당 픽셀 수
    public const float tileSizePixels = 16f; // 타일의 픽셀 크기
    #endregion

    #region DUNGEON BUILD SETTINGS
    // 던전 생성 설정
    public const int maxDungeonRebuildAttemptsForRoomGraph = 1000; // 방 그래프를 다시 생성할 최대 시도 횟수
    public const int maxDungeonBuildAttempts = 10; // 던전 생성 최대 시도 횟수
    #endregion

    #region ROOM SETTINGS
    // 방 설정
    public const float fadeInTime = 0.5f; // 방 페이드 인 시간
    public const int maxChildCorridors = 3; // 방에서 이어지는 최대 복도 수 - 최대값은 3이며, 너무 많을 경우 방이 서로 맞지 않아 던전 생성 실패 가능성이 증가함
    public const float doorUnlockDelay = 1f; // 문이 잠금 해제되기까지의 지연 시간
    #endregion

    #region ANIMATOR PARAMETERS
    // 애니메이터 매개변수 - 플레이어
    public static int aimUp = Animator.StringToHash("aimUp");
    public static int aimDown = Animator.StringToHash("aimDown");
    public static int aimUpRight = Animator.StringToHash("aimUpRight");
    public static int aimUpLeft = Animator.StringToHash("aimUpLeft");
    public static int aimRight = Animator.StringToHash("aimRight");
    public static int aimLeft = Animator.StringToHash("aimLeft");
    public static int isIdle = Animator.StringToHash("isIdle");
    public static int isMoving = Animator.StringToHash("isMoving");
    public static int rollUp = Animator.StringToHash("rollUp");
    public static int rollRight = Animator.StringToHash("rollRight");
    public static int rollLeft = Animator.StringToHash("rollLeft");
    public static int rollDown = Animator.StringToHash("rollDown");
    public static int flipUp = Animator.StringToHash("flipUp");
    public static int flipRight = Animator.StringToHash("flipRight");
    public static int flipLeft = Animator.StringToHash("flipLeft");
    public static int flipDown = Animator.StringToHash("flipDown");
    public static int use = Animator.StringToHash("use");
    public static float baseSpeedForPlayerAnimations = 8f;


    // 애니메이터 매개변수 - 적
    public static float baseSpeedForEnemyAnimations = 3f; // 적 애니메이션 기본 속도

    // 애니메이터 매개변수 - 문
    public static int open = Animator.StringToHash("open"); // 열기

    // 애니메이터 매개변수 - 파괴 가능한 장식물
    public static int destroy = Animator.StringToHash("destroy"); // 파괴
    public static String stateDestroyed = "Destroyed"; // 파괴 상태
    #endregion

    #region GAMEOBJECT TAGS
    // 게임 오브젝트 태그
    public const string playerTag = "Player"; // 플레이어 태그
    public const string playerWeapon = "playerWeapon"; // 플레이어 무기 태그
    #endregion

    #region AUDIO
    // 오디오 설정
    public const float musicFadeOutTime = 0.5f; // 음악 페이드 아웃 시간
    public const float musicFadeInTime = 0.5f; // 음악 페이드 인 시간
    #endregion

    #region FIRING CONTROL
    // 발사 제어 설정
    public const float useAimAngleDistance = 3.5f; // 대상 거리와 무기 각도 사용 기준 거리
    #endregion

    #region ASTAR PATHFINDING PARAMETERS
    // A* 경로 탐색 매개변수
    public const int defaultAStarMovementPenalty = 40; // 기본 이동 패널티
    public const int preferredPathAStarMovementPenalty = 1; // 선호 경로 이동 패널티
    public const int targetFrameRateToSpreadPathfindingOver = 60; // 경로 탐색 분산을 위한 목표 프레임 속도
    public const float playerMoveDistanceToRebuildPath = 3f; // 경로 재구축을 위한 플레이어 이동 거리
    public const float enemyPathRebuildCooldown = 2f; // 적 경로 재구축 쿨다운
    #endregion

    #region ENEMY PARAMETERS
    // 적 매개변수
    public const int defaultEnemyHealth = 20; // 기본 적 체력
    #endregion

    #region UI PARAMETERS
    // UI 매개변수
    public const float uiHeartSpacing = 16f; // 하트 아이콘 간격
    public const float uiAmmoIconSpacing = 4f; // 탄약 아이콘 간격
    #endregion

    #region CONTACT DAMAGE PARAMETERS
    // 접촉 피해 매개변수
    public const float contactDamageCollisionResetDelay = 0.5f; // 접촉 충돌 재설정 지연 시간
    #endregion

    #region HIGHSCORES
    // 최고 점수 설정
    public const int numberOfHighScoresToSave = 100; // 저장할 최고 점수 수
    #endregion
}
