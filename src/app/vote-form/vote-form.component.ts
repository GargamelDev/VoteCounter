import { Component, OnInit } from '@angular/core';
import { VoterService } from '../voter/voter.service';
import { Voter } from '../models/voter';
import { Vote } from '../models/vote';
import { Candidate } from '../models/candidate';
import { CandidateService } from '../candidate/candidate.service';
import { VoteService } from '../vote/vote.service';

@Component({
  selector: 'app-vote-form',
  templateUrl: './vote-form.component.html',
  styleUrls: ['./vote-form.component.css'],
})
export class VoteFormComponent implements OnInit {
  vote: Vote = {
    id: 0,
    voterId: 0,
    candidateId: 0,
  };
  voters: Voter[] = [];
  candidates: Candidate[] = [];

  constructor(
    private voterService: VoterService,
    private candidateService: CandidateService,
    private voteService: VoteService
  ) {}
  ngOnInit(): void {
    this.voterService
      .getAvailableVoters()
      .subscribe((data) => (this.voters = data));
    this.candidateService
      .getCandidates()
      .subscribe((data) => (this.candidates = data));
  }

  submit(): void {
    var result$ = this.voteService.create(this.vote);
    result$.subscribe(
      (data) => {
        console.log('success');
      },
      (error) => {
        console.log('error');
      }
    );
  }
}
