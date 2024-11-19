/*
 * WCF Service: Contract
 * lufer&Oscar
 * */
using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface ICalcService
{

		[OperationContract]	
		int Sum(int x, int y);

        [OperationContract]
		int Sub(int x, int y);
  
		[OperationContract]
		float Div(int x, int y);

		[OperationContract]
		int Mult(int x, int y);




}
