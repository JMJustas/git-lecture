---
theme: uncover
marp: true
---
# What a Git?

A crash course on Version Control Systems

---
## What are VCS'es useful for?

- Keeping track of changes to your work
- Collaborating on a project with multiple peers
- Essential part of CI/CD pipelines

---
## Part 1: VCS for versioning your own work

---
### Git file states
![](file_states_git.jpeg)
  
---
### Let's try it out!
![w:500](live_demo.jpeg)

---
## Part 2: VCS for team collaboration

- Working in parallel tracks(branching)
- Remote repositories

---
### Branching: commit log
![](basic_commit_history.svg)
```sh
git log --graph --oneline
```

---
### Branching: creating a new branch
![](creating_a_branch.svg)
```sh
git branch crazy-experiment
git checkout -b crazy-experiment
```

---
### Branching: a simple parallel track workflow
![w:800](basic_branching.png)
```sh
git checkout -b new_feature
git commit -am "Restructure login controller"
git commit -am "Add rate limiting for password reset function"
git checkout master 
git merge new_feature # normally done through a PR
```

---
### Working with remote repositories
```sh
git remote add origin # connect your local git repo to a remote one
git clone # "download" repository contents for the first time
git pull # fetch latest changes from remote repository
git push # upload changes on your current branch to a remote repo
```
---
### Pull requests: purpose

- Ensuring code quality
- Sharing knowledge between team members

---
## Pull requests: creating a PR
- Limit the scope:
    - Avoid redundant style changes
    - Solve one problem per PR only
- Write a clear PR description (VERY important!):
    - Describe the reason for the PR
    - Describe your solution
    - Describe any gotchas/quirks you've encountered when working
    - Include link to your issue tracker
- 

---
## Pull requests: reviewing a PR
- Read description and intention of the PR thoroughly.
- Be polite with your feedback.
- Be pragmatic - don't argue about minor things.
- PRO tip: be sure to include PR description to the merge commit ;)

---
## Pull requests: merge vs squash-merge

---
## Solving merge conflicts

---
## A more complex branching model
![w:800](basic_branching.png)
---
## Practical tips and tricks
- Annotation
- Cherry-picking
- Rebasing
- Bisecting

---
## Sources
Some images and information are taken from following sources:

- https://lynn-kwong.medium.com/understand-different-git-states-and-the-corresponding-file-states-fc62348e81d7
- https://www.atlassian.com/git/tutorials/using-branches
- https://gitbookdown.dallasdatascience.com/branching-git-branch.html
- https://myst729.github.io/posts/2019/on-merging-pull-requests/
