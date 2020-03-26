import { Component, OnInit } from "@angular/core";
import {
  HttpClient,
  HttpRequest,
  HttpEventType,
  HttpResponse
} from "@angular/common/http";

@Component({
  selector: "app-submit-repayment",
  templateUrl: "./submit-repayment.component.html",
  styleUrls: ["./submit-repayment.component.css"]
})
export class SubmitRepaymentComponent implements OnInit {
  public progress: number;
  public message: string;
  constructor(private http: HttpClient) {}

  selectedFile: File;

  onFileChanged(event) {
    this.selectedFile = event.target.files[0];
    const fileReader = new FileReader();
    fileReader.readAsText(this.selectedFile, "UTF-8");
    fileReader.onload = () => {
      console.log(JSON.parse(this.arrayBufferToString(fileReader.result)));
    };
    fileReader.onerror = error => {
      console.log(error);
    };
  }

  arrayBufferToString(buffer) {
    var arr = new Uint8Array(buffer);
    var str = String.fromCharCode.apply(String, arr);
    if (/[\u0080-\uffff]/.test(str)) {
      throw new Error(
        "this string seems to contain (still encoded) multibytes"
      );
    }
    return str;
  }

  onUpload() {
    // upload code goes here
  }

  upload(files) {
    if (files.length === 0) return;

    const formData = new FormData();

    for (let file of files) formData.append(file.name, file);

    const uploadReq = new HttpRequest("POST", `repay`, formData, {
      reportProgress: true
    });

    this.http.request(uploadReq).subscribe(event => {
      if (event.type === HttpEventType.UploadProgress)
        this.progress = Math.round((100 * event.loaded) / event.total);
      else if (event.type === HttpEventType.Response)
        this.message = event.body.toString();
    });
  }

  ngOnInit() {}
}
