import { Component } from '@angular/core';
import { CandidateService } from '../candidate/candidate.service';
import { Candidate } from '../models/candidate';

@Component({
  selector: 'app-candidate-form',
  templateUrl: './candidate-form.component.html',
  styleUrls: ['./candidate-form.component.css'],
})
export class CandidateFormComponent {
  candidate: Candidate;

  constructor(private candidateService: CandidateService) {
    this.candidate = {
      id: 0, 
      name: '', 
      votes: 0
    }
  }

  submit(): void {
    var result$ = this.candidateService.create(this.candidate);
    result$.subscribe(data=> {
      console.log("success");
      console.log(data);
    }, error=> {
      console.log("failure");
      console.log(error);
    })
  }
}
