using System;
using System.Linq;
using PochtaSdk.Otpravka;
using RestSharp.Authenticators;
using Restub;

namespace PochtaSdk
{
    /// <summary>
    /// Pochta.ru Otpravka API client
    /// https://otpravka.pochta.ru/specification
    /// </summary>
    public class OtpravkaClient : RestubClient
    {
        public const string BaseUrl = "https://otpravka-api.pochta.ru/1.0/";

        public OtpravkaClient(OtpravkaCredentials credentials)
            : base(BaseUrl, credentials)
        {
        }

        public OtpravkaClient(string baseUrl, OtpravkaCredentials credentials)
            : base(baseUrl, credentials)
        {
        }

        protected override IAuthenticator CreateAuthenticator() =>
            new OtpravkaAuthenticator(this, (OtpravkaCredentials)Credentials);

        /// <summary>
        /// Address normalization.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
        /// </summary>
        /// <param name="address">Address to normalize.</param>
        /// <returns>Normalized address.</returns>
        public Address CleanAddress(string address) =>
            Post<Address[]>("clean/address", new[]
            {
                new AddressRequest
                {
                    ID = "adr1",
                    OriginalAddress = address,
                }
            })
            .FirstOrDefault();

        /// <summary>
        /// Address normalization, batch mode.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_adress
        /// </summary>
        /// <param name="addresses">Addresses to normalize.</param>
        /// <returns>Normalized addresses, in the same order.</returns>
        public Address[] CleanAddress(params string[] addresses)
        {
            var req = addresses.Select((a, i) => new AddressRequest
            {
                ID = i.ToString(),
                OriginalAddress = a,
            });

            var result = Post<Address[]>("clean/address", req.ToArray());

            // make sure that normalized addresses are returned in the same order
            return result.OrderBy(a => Convert.ToInt32(a.ID)).ToArray();
        }

        /// <summary>
        /// Person full name normalization.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_fio
        /// </summary>
        /// <param name="fullName">Full name to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public FullName CleanFullName(string fullName) =>
            Post<FullName[]>("clean/physical", new[]
            {
                new FullNameRequest
                {
                    ID = "person1",
                    OriginalFullName = fullName,
                }
            })
            .FirstOrDefault();

        /// <summary>
        /// Person full name normalization.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_fio
        /// </summary>
        /// <param name="fullName">Full name to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public FullName[] CleanFullName(params string[] fullNames)
        {
            var req = fullNames.Select((a, i) => new FullNameRequest
            {
                ID = i.ToString(),
                OriginalFullName = a,
            });

            var result = Post<FullName[]>("clean/physical", req.ToArray());

            // make sure that normalized names are returned in the same order
            return result.OrderBy(a => Convert.ToInt32(a.ID)).ToArray();
        }

        /// <summary>
        /// Phome number normalization.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
        /// </summary>
        /// <param name="phone">Phone number to normalize.</param>
        /// <returns>Normalized person full name.</returns>
        public Phone CleanPhone(string phone) =>
            Post<Phone[]>("clean/phone", new[]
            {
                new PhoneRequest
                {
                    ID = "phone1",
                    OriginalPhone = phone,
                }
            })
            .FirstOrDefault();

        /// <summary>
        /// Phome number normalization.
        /// https://otpravka.pochta.ru/specification#/nogroup-normalization_phone
        /// </summary>
        /// <param name="phones">Phone numbersto normalize.</param>
        /// <returns>Normalized phone numbers in the same order.</returns>
        public Phone[] CleanPhone(params string[] phones)
        {
            var req = phones.Select((a, i) => new PhoneRequest
            {
                ID = i.ToString(),
                OriginalPhone = a,
            });

            var result = Post<Phone[]>("clean/phone", req.ToArray());

            // make sure that normalized phones are returned in the same order
            return result.OrderBy(a => Convert.ToInt32(a.ID)).ToArray();
        }
    }
}
