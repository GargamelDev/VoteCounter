import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Candidate } from '../models/candidate';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {
  create(candidate: Candidate) : Observable<Candidate> {
    return this.http.post<Candidate>(this.candidateUrl, candidate);
  }
  private url:string = "https://localhost:7206/";
  private candidateUrl: string = this.url + 'Candidate';

  constructor(private http: HttpClient) { }

  getCandidates() :Observable<Candidate[]> {
    return this.http.get<Candidate[]>(this.candidateUrl);
  }
}
