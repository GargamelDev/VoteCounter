import { Component, OnInit } from '@angular/core';
import { Voter } from '../models/voter';
import { VoterService } from '../voter/voter.service';

@Component({
  selector: 'app-voter-form',
  templateUrl: './voter-form.component.html',
  styleUrls: ['./voter-form.component.css']
})
export class VoterFormComponent implements OnInit {
  voter: Voter;

  constructor(private voterService: VoterService){
    this.voter = {
      id: 0,
      name: '', 
      hasVoted: false
    };
    console.log(this.voter);
  }
  ngOnInit(): void {
    console.log(this.voter);
  }

  submit():void  {
    
    console.log("test");
    var result$ = this.voterService.create(this.voter);
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
