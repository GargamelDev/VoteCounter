import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Voter } from '../models/voter';
import { Candidate } from '../models/candidate';
import { Vote } from '../models/vote';

@Injectable({
  providedIn: 'root'
})
export class VoterService {
  private url:string = "https://localhost:7206/"
  private voterUrl:string = this.url + 'Voter';

  constructor(private http: HttpClient) { }

  getVoters() :Observable<Voter[]> {
    return this.http.get<Voter[]>(this.voterUrl );
  }

  
  getAvailableVoters() :Observable<Voter[]> {
    return this.http.get<Voter[]>(this.voterUrl + "/Available" );
  }

  create(voter: Voter): Observable<Voter> {
    return this.http.post<Voter>(this.voterUrl, voter);
  }
}
