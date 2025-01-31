﻿namespace AB

open FSharp.Data

type RepositoriesProvider = JsonProvider<"""
{
  "count": 3,
  "value": [
    {
      "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
      "name": "AnotherRepository",
      "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
      "project": {
        "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
        "name": "Fabrikam-Fiber-Git",
        "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
        "state": "wellFormed"
      },
      "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
    },
    {
      "id": "278d5cd2-584d-4b63-824a-2ba458937249",
      "name": "Fabrikam-Fiber-Git",
      "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
      "project": {
        "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
        "name": "Fabrikam-Fiber-Git",
        "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
        "state": "wellFormed"
      },
      "defaultBranch": "refs/heads/master",
      "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
    },
    {
      "id": "66efb083-777a-4cac-a350-a24b046be6be",
      "name": "TestGit",
      "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
      "project": {
        "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
        "name": "TestGit",
        "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
        "state": "wellFormed"
      },
      "defaultBranch": "refs/heads/master",
      "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
    }
  ]
}
""">

type ABC() =
    member this.Load() =
        async {
            let repos = RepositoriesProvider.Parse(
                """
{
    "count": 3,
    "value": [
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        },
        {
            "id": "5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "name": "AnotherRepository",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/5febef5a-833d-4e14-b9c0-14cb638f91e6",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "remoteUrl": "https://dev.azure.com/fabrikam/Fabrikam-Fiber-Git/_git/AnotherRepository"
        },
        {
            "id": "278d5cd2-584d-4b63-824a-2ba458937249",
            "name": "Fabrikam-Fiber-Git",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249",
            "project": {
                "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "name": "Fabrikam-Fiber-Git",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/Fabrikam-Fiber-Git"
        },
        {
            "id": "66efb083-777a-4cac-a350-a24b046be6be",
            "name": "TestGit",
            "url": "https://dev.azure.com/fabrikam/_apis/git/repositories/66efb083-777a-4cac-a350-a24b046be6be",
            "project": {
                "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "name": "TestGit",
                "url": "https://dev.azure.com/fabrikam/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
                "state": "wellFormed"
            },
            "defaultBranch": "refs/heads/master",
            "remoteUrl": "https://dev.azure.com/fabrikam/_git/TestGit"
        }
    ]
}
                """
            )
            
            return repos.Value[0].RemoteUrl
        }
        |> Async.StartAsTask