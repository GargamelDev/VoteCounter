import { Component, OnInit } from '@angular/core';
import { VoterService } from '../voter/voter.service';
import { Voter } from '../models/voter';

@Component({
  selector: 'app-voter-list',
  templateUrl: './voter-list.component.html',
  styleUrls: ['./voter-list.component.css']
})
export class VoterListComponent implements OnInit {
  voters: Voter[] = [];

  constructor(private voterService: VoterService){}
  ngOnInit(): void {
    this.voterService.getVoters().subscribe(data=> this.voters = data);
  }


}
