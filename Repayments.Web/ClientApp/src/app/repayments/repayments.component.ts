import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-repayments',
  templateUrl: './repayments.component.html',
  styleUrls: ['./repayments.component.css']
})
export class RepaymentsComponent implements OnInit {
  public loading = true;
  public repayments: Repayment[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Repayment[]>(baseUrl + 'Repayments')
    .subscribe(result => {
      this.repayments = result;
      this.loading = false;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}

interface Repayment {
  customerName: string;
  seasonName: string;
  date: string;
  amount: number;
}
